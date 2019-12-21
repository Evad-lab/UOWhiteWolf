using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class Vincent : BaseQuester
	{
		[Constructable]
		public Vincent() : base( "the brewer" )
		{
		}

		public Vincent( Serial serial ) : base( serial )
		{
		}

		public override void InitBody()
		{
			InitStats( 100, 100, 25 );

			Hue = 0x83F8;

			Female = false;
			Body = 0x190;
			Name = "Vincent Gasto";
		}

		public override void InitOutfit()
		{
			AddItem( new FancyShirt( 1436 ) );
			AddItem( new LongPants( 0x546 ) );
			AddItem( new Boots( 0x452 ) );
			AddItem( new HalfApron( 1436 ) );

			AddItem( new ShortHair( 1645 ) );
		}

		public override bool CanTalkTo( PlayerMobile to )
		{
			QuestSystem qs = to.Quest as TheGraveDiggerQuest;

			if ( qs == null )
				return false;

			return ( qs.IsObjectiveInProgress( typeof( FindVincentObjective ) )
				|| qs.IsObjectiveInProgress( typeof( VincentsLittleGirlObjective ) )
				|| qs.IsObjectiveInProgress( typeof( ReturnToDrunkObjective ) ) 
				|| qs.IsObjectiveInProgress( typeof( ReturnToVincentObjective ) ) );
		}

		public override void OnTalk( PlayerMobile player, bool contextMenu )
		{
			QuestSystem qs = player.Quest;

			if ( qs is TheGraveDiggerQuest )
			{
				Direction = GetDirectionTo( player );

				QuestObjective obj = qs.FindObjective( typeof( FindVincentObjective ) );

				if ( obj != null && !obj.Completed )
				{
					obj.Complete();

					if ( player.Backpack != null )
					{
						player.Backpack.ConsumeUpTo( typeof( Yeast ), 1 );
						player.Backpack.ConsumeUpTo( typeof( AsianOil ), 1 );
						player.Backpack.ConsumeUpTo( typeof( RiceFlavorSticks ), 1 );
						player.Backpack.ConsumeUpTo( typeof( PureGrainAlcohol ), 1 );
					}
				}
				else if ( qs.IsObjectiveInProgress( typeof( VincentsLittleGirlObjective ) ) )
				{
					qs.AddConversation( new DuringSearchConversation() );
				}
				else
				{
					obj = qs.FindObjective( typeof( ReturnToVincentObjective ) );

					if ( obj != null && !obj.Completed )
					{
						Item brew = new VincentsBrew();

						if ( !player.PlaceInBackpack( brew ) )
						{
							brew.Delete();
							player.SendLocalizedMessage( 1046260 ); // You need to clear some space in your inventory to continue with the quest.  Come back here when you have more space in your inventory.
						}
						else
						{
							obj.Complete();
						}
					}
				}
			}
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}