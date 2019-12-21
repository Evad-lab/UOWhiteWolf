using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class YoungThug : BaseCreature
	{
		private DateTime m_DecayTime;
		private Timer m_Timer;

		public override bool AlwaysAttackable{ get{ return true; } }

		[Constructable]
		public YoungThug() : base( AIType.AI_Animal, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the thug";
			Hue = Utility.RandomSkinHue();
			BodyValue = 400;
			Name = NameList.RandomName( "male" );
			Female = false;

			SetStr( 150 );
			SetDex( 95 );
			SetInt( 50 );

			SetHits( 500 );

			SetDamage( 10, 23 );

			SetSkill( SkillName.Fencing, 66.0, 97.5 );
			SetSkill( SkillName.Macing, 65.0, 87.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Swords, 65.0, 87.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 15.0, 37.5 );

			Fame = 1000;
			Karma = -1000;

			AddItem( new Boots( 1175 ) );
			AddItem( new FancyShirt() );
			AddItem( new LongPants( 1175 ) );
			AddItem( new Cutlass() );

			//AddItem( Server.Items.Hair.GetRandomHair( Female ) );


			m_DecayTime = DateTime.UtcNow + TimeSpan.FromMinutes( 10.0 );

			m_Timer = new InternalTimer( this, m_DecayTime );
			m_Timer.Start();
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}

		public YoungThug( Serial serial ) : base( serial )
		{
		}

		public override void OnAfterDelete()
		{
			if ( m_Timer != null )
				m_Timer.Stop();

			base.OnAfterDelete();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.WriteDeltaTime( m_DecayTime );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_DecayTime = reader.ReadDeltaTime();

					m_Timer = new InternalTimer( this, m_DecayTime );
					m_Timer.Start();

					break;
				}
			}
		}

		private class InternalTimer : Timer
		{
			private Mobile m_Mob;

			public InternalTimer( Mobile mob, DateTime end ) : base( end - DateTime.UtcNow )
			{
				m_Mob = mob;
			}

			protected override void OnTick()
			{
				m_Mob.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );
				m_Mob.PlaySound( 510 );
				m_Mob.Delete();
				Stop();
			}
		}
	}
}
