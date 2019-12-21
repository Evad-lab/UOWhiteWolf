using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class IngotKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 3; } }
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ResourceEntry( typeof( IronIngot ), "Iron" ) );
				entry.Add( new ResourceEntry( typeof( DullCopperIngot ), "Dull" ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronIngot ), "Shadow" ) );
				entry.Add( new ResourceEntry( typeof( CopperIngot ), "Copper" ) );
				entry.Add( new ResourceEntry( typeof( BronzeIngot ), "Bronze" ) );
				entry.Add( new ResourceEntry( typeof( GoldIngot ), "Gold" ) );
				entry.Add( new ResourceEntry( typeof( AgapiteIngot ), "Agapite" ) );
				entry.Add( new ResourceEntry( typeof( VeriteIngot ), "Verite" ) );
				entry.Add( new ResourceEntry( typeof( ValoriteIngot ), "Valorite" ) );
				entry.Add( new ResourceEntry( typeof( BlazeIngot ), "Blaze" ) );
				entry.Add( new ResourceEntry( typeof( IceIngot ), "Ice" ) );
				entry.Add( new ResourceEntry( typeof( ToxicIngot ), "Toxic" ) );
				entry.Add( new ResourceEntry( typeof( ElectrumIngot ), "Electrum" ) );
				entry.Add( new ResourceEntry( typeof( PlatinumIngot ), "Platinum" ) );
                //entry.Add(new ResourceEntry(typeof(CorundumIngot), "Corundum"));
                //entry.Add(new ResourceEntry(typeof(NexusIngot), "Nexus"));
                //entry.Add(new ResourceEntry(typeof(TitanIngot), "Titan"));
				
				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( IronOre ), "Iron" ) );
				entry.Add( new ResourceEntry( typeof( DullCopperOre ), "Dull" ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronOre ), "Shadow" ) );
				entry.Add( new ResourceEntry( typeof( CopperOre ), "Copper" ) );
				entry.Add( new ResourceEntry( typeof( BronzeOre ), "Bronze" ) );
				entry.Add( new ResourceEntry( typeof( GoldOre ), "Gold" ) );
				entry.Add( new ResourceEntry( typeof( AgapiteOre ), "Agapite" ) );
				entry.Add( new ResourceEntry( typeof( VeriteOre ), "Verite" ) );
				entry.Add( new ResourceEntry( typeof( ValoriteOre ), "Valorite" ) );
				entry.Add( new ResourceEntry( typeof( BlazeOre ), "Blaze" ) );
				entry.Add( new ResourceEntry( typeof( IceOre ), "Ice" ) );
				entry.Add( new ResourceEntry( typeof( ToxicOre ), "Toxic" ) );
				entry.Add( new ResourceEntry( typeof( ElectrumOre ), "Electrum" ) );
				entry.Add( new ResourceEntry( typeof( PlatinumOre ), "Platinum" ) );
                //entry.Add(new ResourceEntry(typeof(CorundumOre), "Corundum"));
                //entry.Add(new ResourceEntry(typeof(NexusOre), "Nexus"));
                //entry.Add(new ResourceEntry(typeof(TitanOre), "Titan"));

				return entry;
			}
		}
		
		
		
		[Constructable]
		public IngotKey() : base( 0x14 )		//hue 0x14
		{
			ItemID = 0x1BE8;			//pile of ingots
			Name = "Ingot Keys";
			LootType = LootType.Blessed;
		}
		
		
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "Ingot Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = true;
			return store;
		}
		
		//serial constructor
		public IngotKey( Serial serial ) : base( serial )
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