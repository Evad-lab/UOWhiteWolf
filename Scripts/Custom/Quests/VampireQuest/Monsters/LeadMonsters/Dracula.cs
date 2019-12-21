/////////////////
///LostSinner///
///////////////

using System;
using Server;
using System.Collections;
using Server.Misc;
using Server.Items;
using Server.Network;

namespace Server.Mobiles 
{ 
	[CorpseName( "an detestable corpse" )] 
	public class Dracula : BaseCreature 
	{ 
		private Timer m_Timer;

		private bool m_FieldActive;
		public bool FieldActive{ get{ return m_FieldActive; } }
		public bool CanUseField{ get{ return Hits >= HitsMax * 5 / 10; } } // TODO: an OSI bug prevents to verify this

		public override bool IsScaredOfScaryThings{ get{ return false; } }
		public override bool IsScaryToPets{ get{ return true; } }


		[Constructable] 
		public Dracula() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Title = "Lord of the Dead";
			Name = ( "Dracula" );
			Body = 400;
			Hue = 0;  // Pale Hue

			SetStr( 900, 1200 );
			SetDex( 150, 180 );
			SetInt( 960, 1200 );

			SetHits( 1200, 1600 );

			SetDamage( 10, 12 );
			
			SetResistance( ResistanceType.Physical, 0, 1 );
			SetResistance( ResistanceType.Fire, 35 );
			SetResistance( ResistanceType.Poison, 60 );
			SetResistance( ResistanceType.Energy, 60 );
			SetResistance( ResistanceType.Cold, 60 );

			SetSkill( SkillName.EvalInt, 150.0, 175.0 );
			SetSkill( SkillName.Tactics, 120.0, 145.0 );
			SetSkill( SkillName.MagicResist, 120.0, 145.0 );
			SetSkill( SkillName.Wrestling, 130.0, 155.0 );
			SetSkill( SkillName.Meditation, 120.0, 155.0 );
			SetSkill( SkillName.Focus, 120.0, 155.0 );
			SetSkill( SkillName.Magery, 150.0, 175.0 );

			Fame = -15000;
			Karma = -25000;

			VirtualArmor = 10;
						
			Sandals sandals = new Sandals();
			sandals.Hue = 1;
			EquipItem( sandals );
			
			DraculasShroud DraculasShroud = new DraculasShroud();
			DraculasShroud.Hue = 1;
			EquipItem( DraculasShroud );
					

			m_Timer = new TeleportTimer( this );
			m_Timer.Start();
			m_FieldActive = CanUseField;
			
		}
		
		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich );
			AddLoot( LootPack.UltraRich );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 ); 	
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BardImmune{ get{ return true; } }
		public override bool Unprovokable{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public override void AlterMeleeDamageFrom( Mobile from, ref int damage )
		{
			if ( m_FieldActive )
				damage = 0; // no melee damage when the field is up
		}

		public override void AlterSpellDamageFrom( Mobile from, ref int damage )
		{
			if ( !m_FieldActive )
				damage = 0; // no spell damage when the field is down
		}

		public override void OnDamagedBySpell( Mobile from )
		{
			if( from != null && from.Alive && 0.4 > Utility.RandomDouble() )
			{
				SendEBolt( from );
			}

			if ( !m_FieldActive )
			{
				// should there be an effect when spells nullifying is on?
				this.FixedParticles( 0, 10, 0, 0x2522, EffectLayer.Waist );
			}
			else if ( m_FieldActive && !CanUseField )
			{
				m_FieldActive = false;

				// TODO: message and effect when field turns down; cannot be verified on OSI due to a bug
				this.FixedParticles( 0x3735, 1, 30, 0x251F, EffectLayer.Waist );
			}
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( m_FieldActive )
			{
				this.FixedParticles( 0x376A, 20, 10, 0x2530, EffectLayer.Waist );

				PlaySound( 0x2F4 );

				attacker.SendAsciiMessage( "Muahahaha! Do you really think you could hurt me!" );
			}

			if( attacker != null && attacker.Alive && attacker.Weapon is BaseRanged && 0.4 > Utility.RandomDouble() )
			{
				SendEBolt( attacker );
			}
		}

		public override void OnThink()
		{
			base.OnThink();

			// TODO: an OSI bug prevents to verify if the field can regenerate or not
			if ( !m_FieldActive && !IsHurt() )
				m_FieldActive = true;
		}

		public override bool Move( Direction d )
		{
			bool move = base.Move( d );

			if ( move && m_FieldActive && this.Combatant != null )
				this.FixedParticles( 0, 0, 0, 5033, EffectLayer.Waist );

			return move;
		}

		public void SendEBolt( Mobile to )
		{
			this.MovingParticles( to, 0x379F, 7, 0, false, true, 0xBE3, 0xFCB, 0x211 );
			to.PlaySound( 0x229 );
			this.DoHarmful( to );
			AOS.Damage( to, this, 50, 0, 0, 0, 0, 100 );
		}
		public void DrainLife()
		{
			ArrayList list = new ArrayList();

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m == this || !CanBeHarmful( m ) )
					continue;

				if ( m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != this.Team) )
					list.Add( m );
				if ( m is BaseCreature )
					list.Add( m );
				else if ( m.Player )
					list.Add( m );
			}

			foreach ( Mobile m in list )
			{
				DoHarmful( m );

				Say( "Your soul belongs to me!" );
				FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.LeftFoot );

				m.FixedParticles( 0x3709, 1, 30, 9965, 5, 7, EffectLayer.Waist );
				m.FixedParticles( 0x376A, 1, 30, 9502, 5, 3, EffectLayer.Waist );
				m.PlaySound( 0x231 );

				m.SendMessage( "You feel your soul being pulled from your body!" );

				int toDrain = Utility.RandomMinMax( 30, 35 );

				Hits += toDrain;
				m.Damage( toDrain, this );
			}
		}
		public override void OnGaveMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( 0.33>= Utility.RandomDouble() )
				DrainLife();
		}
		private class TeleportTimer : Timer
		{
			private Mobile m_Owner;

			private static int[] m_Offsets = new int[]
			{
				-1, -1,
				-1,  0,
				-1,  1,
				0, -1,
				0,  1,
				1, -1,
				1,  0,
				1,  1
			};

			public TeleportTimer( Mobile owner ) : base( TimeSpan.FromSeconds( 5.0 ), TimeSpan.FromSeconds( 5.0 ) )
			{
				m_Owner = owner;
			}

			protected override void OnTick()
			{
				if ( m_Owner.Deleted )
				{
					Stop();
					return;
				}

				Map map = m_Owner.Map;

				if ( map == null )
					return;

				if ( 0.25 < Utility.RandomDouble() )
					return;

				Mobile toTeleport = null;

				foreach ( Mobile m in m_Owner.GetMobilesInRange( 16 ) )
				{
					if ( m != m_Owner && m.Player && m_Owner.CanBeHarmful( m ) && m_Owner.CanSee( m ) )

					{
						toTeleport = m;
						break;
					}
				}

				if ( toTeleport != null )
				{
					int offset = Utility.Random( 8 ) * 2;

					Point3D to = m_Owner.Location;

					for ( int i = 0; i < m_Offsets.Length; i += 2 )
					{
						int x = m_Owner.X + m_Offsets[(offset + i) % m_Offsets.Length];
						int y = m_Owner.Y + m_Offsets[(offset + i + 1) % m_Offsets.Length];

						if ( map.CanSpawnMobile( x, y, m_Owner.Z ) )
						{
							to = new Point3D( x, y, m_Owner.Z );
							break;
						}
						else
						{
							int z = map.GetAverageZ( x, y );

							if ( map.CanSpawnMobile( x, y, z ) )
							{
								to = new Point3D( x, y, z );
								break;

								
							}
						}
					}
				
					Mobile m = toTeleport;

					Point3D from = m.Location;

					m.Location = to;

					Server.Spells.SpellHelper.Turn( m_Owner, toTeleport );
					Server.Spells.SpellHelper.Turn( toTeleport, m_Owner );

					m.ProcessDelta();

					Effects.SendLocationParticles( EffectItem.Create( from, m.Map, EffectItem.DefaultDuration ), 0x36BD, 20, 10, 5044 );
					Effects.SendLocationParticles( EffectItem.Create(   to, m.Map, EffectItem.DefaultDuration ), 0x36BD, 20, 10, 5044 ); 

					m.PlaySound( 0x1FE );
				}
			}
		}
	
		public Dracula( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}

