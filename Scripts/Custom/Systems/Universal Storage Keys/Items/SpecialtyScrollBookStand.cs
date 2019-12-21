using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;

namespace Server.Items
{
    [FlipableAttribute(0x2D4D, 0x2D4E)]
	public class SpecialtyScrollKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 1; } }

        public override bool CanUseFromPack { get { return true; } }

        public override bool CanUseFromHouse { get { return true; } }

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

                entry.Add
                (
                    new StashEntry
                    (
                        typeof(PowerScroll), "Power Scroll", 500, new StashSortData
                        (
                            new StashSortEntry[]
							{ 
								new StashSortEntry( "Value", "Value" ), 
								new StashSortEntry( "Skill", "Skill" )
							}
                        )
                    )
                );

                entry.Add
                (
                    new StashEntry
                    (
                        typeof(StatCapScroll), "Stat Cap Scroll", 500, new StashSortData
                        (
                            new StashSortEntry[]
							{ 
								new StashSortEntry( "Value", "Value" )
							}
                        )
                    )
                );
               
                //entry.Add
                //(
                //    new StashEntry
                //    (
                //        typeof(ScrollofTranscendence), "Transcendence", 500, new StashSortData
                //        (
                //            new StashSortEntry[]
                //            { 
                //                new StashSortEntry( "Value", "Value" ), 
                //                new StashSortEntry( "Skill", "Skill" )
                //            }
                //        )
                //    )
                //);

                //entry.Add
                //(
                //    new StashEntry
                //    (
                //        typeof(ScrollofAlacrity), "Alacrity", 500, new StashSortData
                //        (
                //            new StashSortEntry[]
                //            { 
                //                new StashSortEntry( "Skill", "Skill" )
                //            }
                //        )
                //    )

                //);

                 //entry.Add
                //(
                //    new StashEntry
                //    (
                //        typeof(PetLevelUpScroll), "Pet Lvl Up Scroll", 500, new StashSortData
                //        (
                //            new StashSortEntry[]
                //            { 
                //                new StashSortEntry( "Value", "Value" )
                //            }
                //        )
                //    )
                //);

                //entry.Add
                //(
                //    new StashEntry
                //    (
                //        typeof(LevelUpScroll), "Level Item Scroll", 500, new StashSortData
                //        (
                //            new StashSortEntry[]
                //            { 
                //                new StashSortEntry( "Value", "Value" )
                //            }
                //        )
                //    )
                //);

                //entry.Add
                //(
                //    new StashEntry
                //    (
                //        typeof(PetPowerScroll), "Pet Power Scroll", 500, new StashSortData
                //        (
                //            new StashSortEntry[]
                //            { 
                //                new StashSortEntry( "Value", "Value" )
                //            }
                //        )
                //    )
                //);
                return entry;
            }
        }

		[Constructable]
		public SpecialtyScrollKey() : base( 0 )
		{
			ItemID = 0x2D4D;
			Name = "Specialty Scroll Book Stand";
			LootType = LootType.Blessed;
		}
		
		protected override ItemStore GenerateItemStore()
		{
			ItemStore store = base.GenerateItemStore();

            store.Label = "Specialty Scroll Book Stand";
			
			store.OfferDeeds = false;
			return store;
		}
		
		public SpecialtyScrollKey( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( 0 );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}