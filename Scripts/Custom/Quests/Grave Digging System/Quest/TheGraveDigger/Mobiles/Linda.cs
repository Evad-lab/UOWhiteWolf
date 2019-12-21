using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using Server.Engines.Quests;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class Linda : BaseQuester
	{
		private Mobile m_BoyFriend;
		private Mobile m_Player;
		private DateTime m_RespondTime;
		private Timer m_Timer;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile BoyFriend
		{
			get{ return m_BoyFriend; }
			set{ m_BoyFriend = value; }
		}

		[Constructable]
		public Linda() : base( "the teenager" )
		{
		}

		public override void InitBody()
		{
			InitStats( 100, 100, 25 );

			Hue = 0x83F3;

			Female = false;
			BodyValue = 401;
			Name = "Linda Gasto";
		}

		public override void InitOutfit()
		{
			AddItem( new FancyDress( 1154 ) );
			AddItem( new FloppyHat( 1154 ) );
			AddItem( new Sandals( 1154 ) );

			AddItem( new LongHair( 1645 ) );
		}

		public override int GetAutoTalkRange( PlayerMobile pm )
		{
			return 3;
		}

		public override bool CanTalkTo( PlayerMobile to )
		{
			return to.Quest is TheGraveDiggerQuest;
		}

		public override void OnTalk( PlayerMobile player, bool contextMenu )
		{
			QuestSystem qs = player.Quest;

			if ( qs is TheGraveDiggerQuest )
			{
				QuestObjective obj = qs.FindObjective( typeof( VincentsLittleGirlObjective ) );

				if ( obj != null && !obj.Completed )
				{
					obj.Complete();
					this.Say( "Sweetie that strange person over there is stairing at me." );
					if ( this.BoyFriend != null )
					{
						m_RespondTime = DateTime.UtcNow + TimeSpan.FromSeconds( 1.0 );
						m_Timer = new InternalTimer( this.BoyFriend, player, m_RespondTime );
						m_Timer.Start();
						m_Player = player;
					}
				}
				else
				{
					this.Say( "Yes? can i help you?" );
				}
			}
		}

		public Linda( Serial serial ) : base( serial )
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

			writer.Write( (int) 1 ); // version

			writer.Write( m_Player );
			writer.Write( m_BoyFriend );
			writer.WriteDeltaTime( m_RespondTime );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					m_Player = reader.ReadMobile();

					goto case 0;
				}
				case 0:
				{
					m_BoyFriend = reader.ReadMobile();
					m_RespondTime = reader.ReadDeltaTime();

					m_Timer = new InternalTimer( this, m_Player, m_RespondTime );
					m_Timer.Start();

					break;
				}
			}
		}

		private class InternalTimer : Timer
		{
			private Mobile m_Mob;
			private Mobile m_Mob2;

			public InternalTimer( Mobile mob, Mobile mob2, DateTime end ) : base( end - DateTime.UtcNow )
			{
				m_Mob = mob;
				m_Mob2 = mob2;
			}

			protected override void OnTick()
			{
				if ( m_Mob != null )
				{
					Mobile m = (Mobile)m_Mob;
					Mobile m2 = (Mobile)m_Mob2;
					m_Mob.Say( "Dont worry my love, My friends can take care of them." );
					int x1 = m.X + Utility.RandomMinMax( 3, 6 );
					int y1 = m.Y - Utility.RandomMinMax( 3, 6 );
					int x2 = m.X - Utility.RandomMinMax( 3, 6 );
					int y2 = m.Y + Utility.RandomMinMax( 3, 6 );

					YoungThug yt1 = new YoungThug();
					yt1.X = x1;
					yt1.Y = y1;
					yt1.Z = m.Z;
					yt1.Map = m.Map;
					yt1.Combatant = m2;
					World.AddMobile( yt1 );

					YoungThug yt2 = new YoungThug();
					yt2.X = x2;
					yt2.Y = y2;
					yt2.Z = m.Z;
					yt2.Map = m.Map;
					yt2.Combatant = m2;
					World.AddMobile( yt2 );

					m.PlaySound( 510 );
				}

				Stop();
			}
		}
	}
}