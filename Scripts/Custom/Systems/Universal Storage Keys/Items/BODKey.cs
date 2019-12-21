using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.BulkOrders;

namespace Server.Items
{
	//item inherited from BaseResourceKey
	public class BODKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 2; } }
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ListEntry( typeof( SmallAlchemyBOD), typeof( SmallBODListEntry), "Sm. Alchemy", 0x2258, 2505 ));
				entry.Add( new ListEntry( typeof( SmallSmithBOD ), typeof( SmallBODListEntry ), "Sm. Blacksmith", 0x2258, 0x44E ));
				entry.Add( new ListEntry( typeof( SmallCarpentryBOD), typeof( SmallBODListEntry), "Sm. Carpentry", 0x2258, 1512 ));
				entry.Add( new ListEntry( typeof( SmallCookingBOD), typeof( SmallBODListEntry), "Sm. Cooking", 0x2258, 1169 ));
				entry.Add( new ListEntry( typeof( SmallFletchingBOD), typeof( SmallBODListEntry), "Sm. Fletching", 0x2258, 1425 ));
				entry.Add( new ListEntry( typeof( SmallInscriptionBOD), typeof( SmallBODListEntry), "Sm. Inscription", 0x2258, 2598 ));
				entry.Add( new ListEntry( typeof( SmallTailorBOD ), typeof( SmallBODListEntry ), "Sm. Tailor", 0x2258, 0x483 ));
				entry.Add( new ListEntry( typeof( SmallTamingBOD), typeof( SmallBODMobileListEntry), "Sm. Taming", 0x2258, 0x1CA ));
				entry.Add( new ListEntry( typeof( SmallTinkerBOD), typeof( SmallBODListEntry), "Sm. Tinkering", 0x2258, 1109 ));

				//entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ListEntry( typeof( LargeAlchemyBOD), typeof( LargeBODListEntry), "Lg. Alchemy", 0x2258, 2505 ));
				entry.Add( new ListEntry( typeof( LargeSmithBOD ), typeof( LargeBODListEntry ), "Lg. Blacksmith", 0x2258, 0x44E ));
				entry.Add( new ListEntry( typeof( LargeCarpentryBOD), typeof( LargeBODListEntry), "Lg. Carpentry", 0x2258, 1512 ));
				entry.Add( new ListEntry( typeof( LargeCookingBOD), typeof( LargeBODListEntry), "Lg. Cooking", 0x2258, 1169 ));
				entry.Add( new ListEntry( typeof( LargeFletchingBOD), typeof( LargeBODListEntry), "Lg. Fletching", 0x2258, 0x1CA ));
				entry.Add( new ListEntry( typeof( LargeInscriptionBOD), typeof( LargeBODListEntry), "Lg. Inscription", 0x2258, 2598 ));
				entry.Add( new ListEntry( typeof( LargeTailorBOD ), typeof( LargeBODListEntry ), "Lg. Tailor", 0x2258, 0x483 ));
				entry.Add( new ListEntry( typeof( LargeTamingBOD), typeof( LargeBODMobileListEntry), "Lg. Taming", 0x2258, 0x1CA ));
				entry.Add( new ListEntry( typeof( LargeTinkerBOD), typeof( LargeBODListEntry), "Lg. Tinkering", 0x2258, 1109 ));
		
				return entry;
			}
		}
		
		
		
		[Constructable]
		public BODKey() : base( 1161 )		//hue 1161 - blaze
		{
			ItemID = 8793;
			Name = "Ultimate BOD Book";
			LootType = LootType.Blessed;
		}
		
		
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "BOD Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = false;
			return store;
		}
		
		//serial constructor
		public BODKey( Serial serial ) : base( serial )
		{
		}
		
		//events
		
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