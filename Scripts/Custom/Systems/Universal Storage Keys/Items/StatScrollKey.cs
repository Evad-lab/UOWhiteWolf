/////////////Stat Scroll Storage Key - Doc////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							

namespace Server.Items
{
	
	public class StatScrollKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 2; } }
		
		public override bool CanUseFromPack{ get{ return true; } }
		
		public override bool CanUseFromHouse{ get{ return true; } }
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add
				( 
					new StashEntry
					(
						typeof( StatCapScroll ), "Stat Scrolls", 500, new StashSortData
						(										
				
						)	 
					) 
				);
			
 				
				return entry;
			}
		}
		
		
		
		[Constructable]
		public StatScrollKey() : base( 0 )
		{
			ItemID = 7960;
			Name = "Stat Scrolls";
			LootType = LootType.Blessed;
		}
		
			
		protected override ItemStore GenerateItemStore()
		{
		
			ItemStore store = base.GenerateItemStore();

		
			store.Label = "Stat Scrolls";
			
			store.OfferDeeds = false;
			return store;
		}
		
	
		public StatScrollKey( Serial serial ) : base( serial )
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