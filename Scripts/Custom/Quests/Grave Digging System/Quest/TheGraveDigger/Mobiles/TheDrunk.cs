using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class TheDrunk : BaseQuester
	{
		[Constructable]
		public TheDrunk() : base( "the grave digger" )
		{
		}

		public TheDrunk( Serial serial ) : base( serial )
		{
		}

		public override void InitBody()
		{
			InitStats( 100, 100, 25 );

			Hue = 0x83ED;

			Female = false;
			Body = 0x190;
			Name = "Samus McNealson";
		}

		public override void InitOutfit()
		{
			AddItem( new Robe( 1102 ) );
			AddItem( new HalfApron( 1000 ) );
			AddItem( new Boots( 0x454 ) );
			AddItem( new FloppyHat( 1102 ) );

			AddItem( new GnarledStaff() );

			AddItem( new PonyTail( 1000 ) );
			AddItem( new Goatee( 1000 ) );
		}

		public override void OnTalk( PlayerMobile player, bool contextMenu )
		{
			Direction = GetDirectionTo( player );

			QuestSystem qs = player.Quest;

			if ( qs is TheGraveDiggerQuest )
			{
				if ( qs.IsObjectiveInProgress( typeof( FindYeastObjective ) ) || qs.IsObjectiveInProgress( typeof( FindAsianOilObjective ) ) || qs.IsObjectiveInProgress( typeof( FindRiceFlavorSticksObjective ) ) || qs.IsObjectiveInProgress( typeof( FindPureGrainAlcoholObjective ) ) )
				{
					qs.AddConversation( new DuringCollectingConversation() );
				}
				else if ( qs.IsObjectiveInProgress( typeof( FindVincentObjective ) ) || qs.IsObjectiveInProgress( typeof( VincentsLittleGirlObjective ) ) || qs.IsObjectiveInProgress( typeof( ReturnToVincentObjective ) ) )
				{
					qs.AddConversation( new DuringBrewingConversation() );
				}
				else
				{
					QuestObjective obj = qs.FindObjective( typeof( ReturnToDrunkObjective ) );

					//obj = qs.FindObjective( typeof( ReturnToDrunkObjective ) );

					if ( obj != null && !obj.Completed )
					{
						obj.Complete();

						if ( player.Backpack != null )
						{
							player.Backpack.ConsumeUpTo( typeof( VincentsBrew ), 1 );
						}

						if ( GiveReward( player ) )
						{
							qs.AddConversation( new EndConversation() );
						}
						else
						{
							qs.AddConversation( new FullEndConversation( true ) );
						}
					}
					else
					{
						obj = qs.FindObjective( typeof( MakeRoomObjective ) );

						if ( obj != null && !obj.Completed )
						{
							if ( GiveReward( player ) )
							{
								obj.Complete();
								qs.AddConversation( new EndConversation() );
							}
							else
							{
								qs.AddConversation( new FullEndConversation( false ) );
							}
						}
					}
				}
			}
			else
			{
				QuestSystem newQuest = new TheGraveDiggerQuest( player );

				if ( qs == null && QuestSystem.CanOfferQuest( player, typeof( TheGraveDiggerQuest ) ) )
				{
					newQuest.SendOffer();
				}
				else
				{
					newQuest.AddConversation( new DontOfferConversation() );
				}
			}
		}

		public bool GiveReward( Mobile to )
		{
			Bag bag = new Bag();

			bag.DropItem( new Gold( Utility.RandomMinMax( 500, 1000 ) ) );

			bag.DropItem( new GraveDiggersShovel() );

			if ( Utility.Random( 1000 ) < 50 )
				bag.DropItem( new BloodPentagramAddonDeed() );
			else if ( Utility.Random( 1000 ) < 50 )
				bag.DropItem( new NecroAltarAddonDeed() );

			return to.PlaceInBackpack( bag );
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