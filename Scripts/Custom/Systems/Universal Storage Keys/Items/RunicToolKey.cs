using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Solaris.ItemStore;							//for connection to resource store data objects
using daat99;

namespace Server.Items
{
	//item derived from BaseResourceKey
	
	public class RunicToolKey : BaseStoreKey
	{
		public override int DisplayColumns{ get{ return 2; } }
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ListEntry( typeof( RunicHammer ), typeof( RunicHammerListEntry ), "Hammers" ) );
				entry.Add( new ListEntry( typeof( RunicSewingKit ), typeof( RunicSewingKitListEntry ), "Sewing Kits" ) );
				entry.Add( new ListEntry( typeof( RunicFletcherTool ), typeof( RunicFletcherToolListEntry ), "Fletcher Tools" ) );
				entry.Add( new ListEntry( typeof( RunicDovetailSaw ), typeof( RunicDovetailSawListEntry ), "Dovetail Saws" ) );
				entry.Add( new ListEntry( typeof( RunicMalletAndChisel ), typeof( RunicMalletAndChiselListEntry ), "Mallet And Chisels" ) );
				entry.Add( new ListEntry( typeof( RunicTinkerTools ), typeof( RunicTinkerToolsListEntry ), "Tinker Tools" ) );
				
				return entry;
				/*
				//
				//original code below (from older versions)
				//
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ResourceEntry( typeof( DullCopperRunicHammer ), "Dull Copper" ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronRunicHammer ), "Shadow Iron" ) );
				entry.Add( new ResourceEntry( typeof( CopperRunicHammer ), "Copper" ) );
				entry.Add( new ResourceEntry( typeof( BronzeRunicHammer ), "Bronze" ) );
				entry.Add( new ResourceEntry( typeof( GoldRunicHammer ), "Gold" ) );
				entry.Add( new ResourceEntry( typeof( AgapiteRunicHammer ), "Agapite" ) );
				entry.Add( new ResourceEntry( typeof( VeriteRunicHammer ), "Verite" ) );
				entry.Add( new ResourceEntry( typeof( ValoriteRunicHammer ), "Valorite" ) );
				entry.Add( new ResourceEntry( typeof( BlazeRunicHammer ), "Blaze" ) );
				entry.Add( new ResourceEntry( typeof( IceRunicHammer ), "Ice" ) );
				entry.Add( new ResourceEntry( typeof( ElectrumRunicHammer ), "Electrum" ) );
				entry.Add( new ResourceEntry( typeof( ToxicRunicHammer ), "Toxic" ) );
				entry.Add( new ResourceEntry( typeof( PlatinumRunicHammer ), "Platinum" ) );

				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( SpinedRunicSewingKit ), "Spined" ) );
				entry.Add( new ResourceEntry( typeof( HornedRunicSewingKit ), "Horned" ) );
				entry.Add( new ResourceEntry( typeof( BarbedRunicSewingKit ), "Barbed" ) );
				entry.Add( new ResourceEntry( typeof( PolarRunicSewingKit ), "Polar" ) );
				entry.Add( new ResourceEntry( typeof( SyntheticRunicSewingKit ), "Synthetic" ) );
				entry.Add( new ResourceEntry( typeof( BlazeRunicSewingKit ), "Blaze" ) );
				entry.Add( new ResourceEntry( typeof( DaemonicRunicSewingKit ), "Daemonic" ) );
				entry.Add( new ResourceEntry( typeof( ShadowRunicSewingKit ), "Shadow" ) );
				entry.Add( new ResourceEntry( typeof( FrostRunicSewingKit ), "Frost" ) );
				entry.Add( new ResourceEntry( typeof( EtherealRunicSewingKit ), "Ethereal" ) );
				
				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( DullCopperRunicTinkerTools ), "Dull Copper" ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronRunicTinkerTools ), "Shadow Iron" ) );
				entry.Add( new ResourceEntry( typeof( CopperRunicTinkerTools ), "Copper" ) );
				entry.Add( new ResourceEntry( typeof( BronzeRunicTinkerTools ), "Bronze" ) );
				entry.Add( new ResourceEntry( typeof( GoldRunicTinkerTools ), "Gold" ) );
				entry.Add( new ResourceEntry( typeof( AgapiteRunicTinkerTools ), "Agapite" ) );
				entry.Add( new ResourceEntry( typeof( VeriteRunicTinkerTools ), "Verite" ) );
				entry.Add( new ResourceEntry( typeof( ValoriteRunicTinkerTools ), "Valorite" ) );
				entry.Add( new ResourceEntry( typeof( BlazeRunicTinkerTools ), "Blaze" ) );
				entry.Add( new ResourceEntry( typeof( IceRunicTinkerTools ), "Ice" ) );
				entry.Add( new ResourceEntry( typeof( ToxicRunicTinkerTools ), "Toxic" ) );
				entry.Add( new ResourceEntry( typeof( ElectrumRunicTinkerTools ), "Electrum" ) );
				entry.Add( new ResourceEntry( typeof( PlatinumRunicTinkerTools ), "Platinum" ) );
				
				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( OakRunicFletcherTools ), "Oak" ) );
				entry.Add( new ResourceEntry( typeof( AshRunicFletcherTools ), "Ash" ) );
				entry.Add( new ResourceEntry( typeof( YewRunicFletcherTools ), "Yew" ) );
				entry.Add( new ResourceEntry( typeof( HeartwoodRunicFletcherTools ), "Heartwood" ) );
				entry.Add( new ResourceEntry( typeof( BloodwoodRunicFletcherTools ), "Bloodwood" ) );
				entry.Add( new ResourceEntry( typeof( FrostwoodRunicFletcherTools ), "Frostwood" ) );
				entry.Add( new ResourceEntry( typeof( EbonyRunicFletcherTools ), "Ebony" ) );
				entry.Add( new ResourceEntry( typeof( BambooRunicFletcherTools ), "Bamboo" ) );
				entry.Add( new ResourceEntry( typeof( PurpleHeartRunicFletcherTools ), "PurpleHeart" ) );
				entry.Add( new ResourceEntry( typeof( RedwoodRunicFletcherTools ), "Redwood" ) );
				entry.Add( new ResourceEntry( typeof( PetrifiedRunicFletcherTools ), "Petrified" ) );
		
				return entry;
				*/
			}
		}

		
		[Constructable]
		public RunicToolKey() : base( 65 )
		{
			ItemID = 0x1EBA;			//square toolkit
			Name = "Runic Tool Box";
			LootType = LootType.Blessed;
			//runic tools withdrawn can have no less than 5 charges on them.
			//_Store.MinWithdrawAmount = 5;
		}
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "Runic Tool Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = true;
			
			return store;
		}
		
		//serial constructor
		public RunicToolKey( Serial serial ) : base( serial )
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