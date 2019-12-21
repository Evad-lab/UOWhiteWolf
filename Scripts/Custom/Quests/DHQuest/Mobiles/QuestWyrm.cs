// Scripted by Karmageddon
using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a dragon corpse" )]
	public class QuestWyrm : BaseCreature
	{
	
		private static Type[] m_DragonHeart = new Type[]
			{
				typeof( DragonHeart )
			};
			
		public static Item CreateHeart()
		{			
			int count = ( m_DragonHeart.Length * 5 );
			int random = Utility.Random( count );
			Type type;
			
			if ( random < ( m_DragonHeart.Length * 5 ) )
			{
				type = m_DragonHeart[random / 5];
			}
			else
			{
				random -= m_DragonHeart.Length * 5;
				type = m_DragonHeart[random / 4];
			}
			
			return Loot.Construct( type );
		}
		
		public static Mobile FindRandomPlayer( BaseCreature creature )
		{
			List<DamageStore> rights = creature.GetLootingRights( );

			for ( int i = rights.Count - 1; i >= 0; --i )
			{
				DamageStore ds = rights[i];

				if ( !ds.m_HasRight )
					rights.RemoveAt( i );
			}

			if ( rights.Count > 0 )
				return rights[Utility.Random( rights.Count )].m_Mobile;

			return null;
		}

		public static void DistributeHeart( BaseCreature creature )
		{
			DistributeHeart( creature, CreateHeart() );
		}

		public static void DistributeHeart( BaseCreature creature, Item heart )
		{
			DistributeHeart( FindRandomPlayer( creature ), heart );
		}

		public static void DistributeHeart( Mobile to )
		{
			DistributeHeart( to, CreateHeart() );
		}

		public static void DistributeHeart( Mobile to, Item heart )
		{
			if ( to == null || heart == null )
				return;

			Container pack = to.Backpack;

			if ( pack == null || !pack.TryDropItem( to, heart, false ) )
				to.BankBox.DropItem( heart );

			to.SendMessage( "Here is your reward for such a valiant fight." ); 
		}
				
		[Constructable]
		public QuestWyrm () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "centaur" );
			Title = "Keeper of the Dragon Heart";
			Body = 46;
			Hue = 0x846;
			BaseSoundID = 362;

			SetStr( 1096, 1185 );
			SetDex( 286, 375 );
			SetInt( 686, 775 );
			ActiveSpeed = -2;

			SetHits( 5658, 5711 );

			SetDamage( 29, 35 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Fire, 25 );

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Fire, 80, 90 );
			SetResistance( ResistanceType.Cold, 70, 80 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 60, 70 );

			SetSkill( SkillName.EvalInt, 80.1, 100.0 );
			SetSkill( SkillName.Magery, 80.1, 100.0 );
			SetSkill( SkillName.Meditation, 52.5, 75.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 197.6, 200.0 );
			SetSkill( SkillName.Wrestling, 197.6, 200.0 );
			SetSkill( SkillName.Anatomy, 197.6, 200.0 );

			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 70;			
			
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 6 );
		}

		public override int GetIdleSound()
		{
			return 0x2D3;
		}

		public override int GetHurtSound()
		{
			return 0x2D1;
		}

		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override bool AutoDispel{ get{ return true; } }
		public override HideType HideType{ get{ return HideType.Horned; } }
		public override int Hides{ get{ return 20; } }
		public override int Meat{ get{ return 19; } }
		public override int Scales{ get{ return 12; } }
		public override ScaleType ScaleType{ get{ return (ScaleType)Utility.Random( 4 ); } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }
		public override int TreasureMapLevel{ get{ return 5; } }

		public QuestWyrm( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDeath( Container c )
		{
			base.OnDeath( c );
			
				QuestWyrm.DistributeHeart( this );
		}
		
		private DateTime m_NextBreathe;

		public override void OnActionCombat()
		{
			Mobile combatant = (Mobile)Combatant;

			if ( combatant == null || combatant.Deleted || combatant.Map != Map || !InRange( combatant, 12 ) || !CanBeHarmful( combatant ) || !InLOS( combatant ) )
				return;

			if ( DateTime.UtcNow >= m_NextBreathe )
			{
				Breathe( combatant );

				m_NextBreathe = DateTime.UtcNow + TimeSpan.FromSeconds( 3.0 + (3.0 * Utility.RandomDouble()) ); // 12-15 seconds
			}
		}

		public void Breathe( Mobile m )
		{
			DoHarmful( m );

			new BreatheTimer( m, this ).Start();

			this.Frozen = false;

			this.MovingParticles( m, 0x36D4, 10, 0, false, true, 0, 0, 9502, 6014, 0x11D, EffectLayer.Waist, 0 );
		}

		private class BreatheTimer : Timer
		{
			private QuestWyrm d;
			private Mobile m_Mobile;

			public BreatheTimer( Mobile m, QuestWyrm owner ) : base( TimeSpan.FromSeconds( 1.0 ), TimeSpan.FromSeconds( 1.0 ) )
			{
				d = owner;
				m_Mobile = m;
			}

			protected override void OnTick()
			{
				int damagemin = d.Hits / 3;
				int damagemax = d.Hits / 8;
				d.Frozen = false;

				m_Mobile.PlaySound( 0x11D );
				AOS.Damage( m_Mobile, Utility.RandomMinMax( damagemin, damagemax ), 0, 100, 0, 0, 0 );
				Stop();
			}
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