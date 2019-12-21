using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;	//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class WoodKey : BaseStoreKey
	{
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ResourceEntry( typeof( Board ), new Type[]{ typeof( Log ) }, "Plain" ) );
                entry.Add( new ResourceEntry( typeof( OakBoard ), new Type[]{ typeof( OakLog ) }, "Oak" ) );
                entry.Add( new ResourceEntry( typeof( YewBoard ), new Type[]{ typeof( YewLog ) }, "Yew" ) );
                entry.Add( new ResourceEntry( typeof( AshBoard ), new Type[]{ typeof( AshLog ) }, "Ash" ) );
                entry.Add( new ResourceEntry( typeof( HeartwoodBoard ), new Type[]{ typeof( HeartwoodLog ) }, "Hearwood" ) );
                entry.Add( new ResourceEntry( typeof( FrostwoodBoard ), new Type[]{ typeof( FrostwoodLog ) }, "Frostwood" ) );
                entry.Add( new ResourceEntry( typeof( BloodwoodBoard ), new Type[]{ typeof( BloodwoodLog ) }, "Bloodwood" ) );
				
				entry.Add( new ResourceEntry( typeof( EbonyBoard ), new Type[]{ typeof( EbonyLog ) }, "Ebony" ) );
                entry.Add( new ResourceEntry( typeof( BambooBoard ), new Type[]{ typeof( BambooLog ) }, "Bamboo" ) );
                entry.Add( new ResourceEntry( typeof( PurpleHeartBoard ), new Type[]{ typeof( PurpleHeartLog ) }, "PurpleHeart" ) );
                entry.Add( new ResourceEntry( typeof( RedwoodBoard ), new Type[]{ typeof( RedwoodLog ) }, "Redwood" ) );
                entry.Add( new ResourceEntry( typeof( PetrifiedBoard ), new Type[]{ typeof( PetrifiedLog ) }, "Petrified" ) );
				
				
				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( Kindling ), "Kindling" ) );
				entry.Add( new ResourceEntry( typeof( Shaft ), "Shaft" ) );
				entry.Add( new ResourceEntry( typeof( Feather ), "Feather" ) );
				entry.Add( new ResourceEntry( typeof( Arrow ), "Arrow" ) );
				entry.Add( new ResourceEntry( typeof( Bolt ), "Bolt" ) );
				
				
				return entry;
			}
		}

		
		[Constructable]
		public WoodKey() : base( 88 )		//hue 88
		{
			ItemID = 0x1BD9;			//pile of wood
			Name = "Wood Storage";
			LootType = LootType.Blessed;
		}
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "Wood Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = true;
			
			return store;
		}
		
		//serial constructor
		public WoodKey( Serial serial ) : base( serial )
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