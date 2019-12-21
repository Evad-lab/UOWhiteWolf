using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class GraniteKey : BaseStoreKey
	{
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				int height = 40;
				
				List<StoreEntry> entry = base.EntryStructure;
				entry.Add( new ResourceEntry( typeof( Granite ), "Plain", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( DullCopperGranite ), "Dull", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronGranite ), "Shadow", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( CopperGranite ), "Copper", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( BronzeGranite ), "Bronze", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( GoldGranite ), "Gold", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( AgapiteGranite ), "Agapite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( VeriteGranite ), "Verite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ValoriteGranite ), "Valorite", 0, height, 0, 0 ) );
				
				
				entry.Add( new ResourceEntry( typeof( BlazeGranite ), "Blaze", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( IceGranite ), "Ice", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ToxicGranite ), "Toxic", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ElectrumGranite ), "Electrum", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( PlatinumGranite ), "Platinum", 0, height, 0, 0 ) );
				return entry;
			}
		}
		
		
		
		[Constructable]
		public GraniteKey() : base( 1161 )		//hue 1161
		{
			ItemID = 0x177C;				//rocks
			LootType = LootType.Blessed;
			Name = "Stone Storage";
		}
		
		
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();
			
			//properties of this storage device
			store.Label = "Stone Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = false;
			
			return store;
		}
		
		//serial constructor
		public GraniteKey( Serial serial ) : base( serial )
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