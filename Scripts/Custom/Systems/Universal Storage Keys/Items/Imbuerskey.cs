// Doc - Key for Imbuing and Augments + more

using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class ImbersKey : BaseStoreKey
	{
		//set the # of columns of entries to display on the gump.. default is 2
		public override int DisplayColumns{ get{ return 3; } }
		
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
								
				entry.Add( new ResourceEntry( typeof( WhitePearl ), "White Pearl" ) );
				entry.Add( new ResourceEntry( typeof( PowderedIron ), "Powdered Iron" ) );
				entry.Add( new ResourceEntry( typeof( ParasiticPlant ), "Parasytic Plant" ) );
				entry.Add( new ResourceEntry( typeof( RelicFragment ), "Relic Fragment" ) );
				entry.Add( new ResourceEntry( typeof( FireRuby ), "Fire Ruby" ) );
				entry.Add( new ResourceEntry( typeof( MagicalResidue ), "Magical Residue" ) );
				//entry.Add( new ResourceEntry( typeof( EnchantEssence ), "Enchanted Essence") );
				entry.Add( new ResourceEntry( typeof( EssencePrecision ), "Essence of Precision" ) );
				entry.Add( new ResourceEntry( typeof( EssenceAchievement ), "Essence of Achievement" ) );
				entry.Add( new ResourceEntry( typeof( EssenceBalance ), "Essence of Balance" ) );
				entry.Add( new ResourceEntry( typeof( EssenceControl ), "Essence of Control" ) );
				entry.Add( new ResourceEntry( typeof( EssenceDiligence ), "Essence of Diligence" ) );
				entry.Add( new ResourceEntry( typeof( EssenceDirection ), "Essence of Direction" ) );
				
				entry.Add( new ResourceEntry( typeof( EssenceFeeling ), "Essence of Feeling") );
				entry.Add( new ResourceEntry( typeof( EssenceOrder ), "Essence of Order") );
				entry.Add( new ResourceEntry( typeof( EssencePassion ), "Essence of Passion") );
				entry.Add( new ResourceEntry( typeof( EssencePersistence ), "Essence Persistence") );
				entry.Add( new ResourceEntry( typeof( EssenceSingularity ), "Essence of Singularity") );
				entry.Add( new ResourceEntry( typeof( AbyssalCloth ), "Abyssal Cloth") );
				entry.Add( new ResourceEntry( typeof( ArcanicRuneStone ), "Arcanic RuneStone") );
				entry.Add( new ResourceEntry( typeof( BottleIchor ), "Bottle Ichor") );
				entry.Add( new ResourceEntry( typeof( BouraPelt ), "Boura Pelt") );
				entry.Add( new ResourceEntry( typeof( ChagaMushroom ), "Chaga Mushroom") );
				entry.Add( new ResourceEntry( typeof( CrushedGlass ), "Crushed Glass") );
				entry.Add( new ResourceEntry( typeof( CrystalShards ), "Crystal Shards") );
				entry.Add( new ResourceEntry( typeof( CrystallineBlackrock ), "Crystalline Blackrock") );
				entry.Add( new ResourceEntry( typeof( DaemonClaw ), "Daemon Claw") );
				entry.Add( new ResourceEntry( typeof( DelicateScales ), "Delicate Scales") );
				//entry.Add( new ResourceEntry( typeof( ElvenFletchings ), "Elven Fletchings") );
				entry.Add( new ResourceEntry( typeof( FaeryDust ), "Faery Dust") );
				entry.Add( new ResourceEntry( typeof( GoblinBlood ), "Goblin Blood") );
				//entry.Add( new ResourceEntry( typeof( LavaSerpenCrust ), "Lava Serpent Crust") );
				entry.Add( new ResourceEntry( typeof( RaptorTeeth ), "Raptor Teeth") );
				entry.Add( new ResourceEntry( typeof( ReflectiveWolfEye ), "Reflective WolfEye") );
				//entry.Add( new ResourceEntry( typeof( SeedRenewal ), "Seed of Renewal") );
				entry.Add( new ResourceEntry( typeof( SilverSnakeSkin ), "Silver SnakeSkin") );
				entry.Add( new ResourceEntry( typeof( SlithTongue ), "Slith Tongue") );
				entry.Add( new ResourceEntry( typeof( SpiderCarapace ), "Spider Carapace") );
				entry.Add( new ResourceEntry( typeof( UndyingFlesh ), "Undying Flesh") );
				//entry.Add( new ResourceEntry( typeof( VialVitirol ), "Vial of Vitirol") );
				entry.Add( new ResourceEntry( typeof( VoidOrb ), "Void Orb") );
				entry.Add( new ColumnSeparationEntry() );
				//entry.Add( new ResourceEntry( typeof( GlimmeringBloodrock ), "Glimmering Bloodrock") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringClay ), "Glimmering Clay") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringGranite ), "Glimmering Granite") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringGypsum ), "Glimmering Gypsum") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringHeartstone ), "Glimmering Heartstone") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringIronOre ), "Glimmering Iron Ore") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringLimestone ), "Glimmering Limestone") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringMarble ), "Glimmering Marble") );
				//entry.Add( new ResourceEntry( typeof( GlimmeringOnyx ), "Glimmering Onyx") );
				entry.Add( new ResourceEntry( typeof( PetrafiedWood ), "Petrafied Wood") );
				//entry.Add( new ResourceEntry( typeof( AncientWood ), "Ancient Wood") );
				//entry.Add( new ResourceEntry( typeof( LegendaryWood ), "Legendary Wood") );
				//entry.Add( new ResourceEntry( typeof( MythicWood ), "Mythic Wood") );
				//entry.Add( new ResourceEntry( typeof( AncientAmethyst ), "Ancient Amethyst") );
				//entry.Add( new ResourceEntry( typeof( LegendaryAmethyst ), "Legendary Amethyst") );
				//entry.Add( new ResourceEntry( typeof( MythicAmethyst ), "Mythic Amethyst") );
				//entry.Add( new ResourceEntry( typeof( AncientEmerald ), "Ancient Emerald") );
				//entry.Add( new ResourceEntry( typeof( LegendaryEmerald ), "Legendary Emerald") );
				//entry.Add( new ResourceEntry( typeof( MythicEmerald ), "Mythic Emerald") );
				//entry.Add( new ResourceEntry( typeof( AncientTourmaline ), "Ancient Tourmaline") );
				//entry.Add( new ResourceEntry( typeof( LegendaryTourmaline ), "Legendary Tourmaline") );
				//entry.Add( new ResourceEntry( typeof( MythicTourmaline ), "Mythic Tourmaline") );
				//entry.Add( new ResourceEntry( typeof( AncientDiamond ), "Ancient Diamond") );
				//entry.Add( new ResourceEntry( typeof( LegendaryDiamond ), "Legendary Diamond") );
				//entry.Add( new ResourceEntry( typeof( MythicDiamond ), "Mythic Diamond") );
				//entry.Add( new ResourceEntry( typeof( AncientSapphire ), "Ancient Sapphire") );
				//entry.Add( new ResourceEntry( typeof( LegendarySapphire ), "Legendary Sapphire") );
				//entry.Add( new ResourceEntry( typeof( MythicSapphire ), "Mythic Sapphire") );
				//entry.Add( new ResourceEntry( typeof( AncientRuby ), "Ancient Ruby") );
				//entry.Add( new ResourceEntry( typeof( LegendaryRuby ), "Legendary Ruby") );
				//entry.Add( new ResourceEntry( typeof( MythicRuby ), "Mythic Ruby") );
				//entry.Add( new ResourceEntry( typeof( AncientSkull ), "Ancient Skull") );
				//entry.Add( new ResourceEntry( typeof( LegendarySkull ), "Legendary Skull") );
				//entry.Add( new ResourceEntry( typeof( MythicSkull ), "Mythic Skull") );
				
				entry.Add( new ColumnSeparationEntry() );
			
			
	    
		
		
		entry.Add( new ResourceEntry( typeof(BlueDiamond), "Blue Diamond") );		
        entry.Add( new ResourceEntry( typeof(DarkSapphire), "Dark Sapphire") );
        entry.Add( new ResourceEntry( typeof(EcruCitrine), "Ecru Citrine") );
        entry.Add( new ResourceEntry( typeof(FireRuby), "Fire Ruby") );
        entry.Add( new ResourceEntry( typeof(PerfectEmerald), "Perfect Emerald") );
        entry.Add( new ResourceEntry( typeof(Turquoise), "Turquoise") );
        entry.Add( new ResourceEntry( typeof(BarkFragment), "Bark Fragment") );
        entry.Add( new ResourceEntry( typeof(LuminescentFungi), "Luminescent Fungi") );
        entry.Add( new ResourceEntry( typeof(SwitchItem), "Switch") );
        entry.Add( new ResourceEntry( typeof(ParasiticPlant), "Parasitic Plant") );
        entry.Add( new ResourceEntry( typeof(BrilliantAmber), "Brilliant Amber") );
        entry.Add( new ResourceEntry( typeof(WhitePearl), "White Pearl") );
		
		entry.Add( new ColumnSeparationEntry() );
		
		entry.Add( new ResourceEntry( typeof(DreadHornMane), "DreadHorn Mane") );		
        entry.Add( new ResourceEntry( typeof(Putrefaction), "Putrefaction") );
        entry.Add( new ResourceEntry( typeof(Muculent), "Muculent") );
        entry.Add( new ResourceEntry( typeof(GrizzledBones), "Grizzled Bones") );
        entry.Add( new ResourceEntry( typeof(Taint), "Taint") );
        entry.Add( new ResourceEntry( typeof(Blight), "Blight") );
        entry.Add( new ResourceEntry( typeof(Scourge), "Scourge") );
        entry.Add( new ResourceEntry( typeof(Corruption), "Corruption") );
        entry.Add( new ResourceEntry( typeof(LardOfParoxysmus), "Lard Of Paroxysmus") );
        entry.Add( new ResourceEntry( typeof(EyeOfTheTravesty), "Eye Of The Travesty") );
        entry.Add( new ResourceEntry( typeof(CapturedEssence), "Captured Essence") );


			
			
			
			
			
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				return entry;
			}
		}

		
		[Constructable]
		public  ImbersKey() : base( 36 )		//hue 1154
		{
			ItemID = 0x1F18;			//display case
			
			Name = "Super Storage";
			LootType = LootType.Blessed;
		}
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = " Super Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = false;
			
			return store;
		}
		
		//serial constructor
		public ImbersKey( Serial serial ) : base( serial )
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