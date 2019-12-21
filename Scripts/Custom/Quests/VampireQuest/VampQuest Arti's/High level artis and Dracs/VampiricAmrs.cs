
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Items;

namespace Server.Items
{

	
	public class VampArms : BoneArms
	{
		public override int BasePhysicalResistance{ get{ return 11; } }
		public override int BaseFireResistance{ get{ return 11; } }
		public override int BaseColdResistance{ get{ return 11; } }
		public override int BasePoisonResistance{ get{ return 11; } }
		public override int BaseEnergyResistance{ get{ return 11; } }

		public override int ArtifactRarity{ get{ return 6; } }

		public override int InitMinHits{ get{ return 1500; } }
		public override int InitMaxHits{ get{ return 1500; } }

		public override int AosStrReq{ get{ return 90; } }
		public override int OldStrReq{ get{ return 90; } }

		public override int OldDexBonus{ get{ return -2; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Bone; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public VampArms()
		{
			ItemID = 5198;
			Weight = 5.0;
			Name = "Lamia Armipotens";
			Hue = 37;
			LootType = LootType.Blessed;
			Attributes.ReflectPhysical = 5;
			Attributes.CastSpeed = 1;
			Attributes.CastRecovery = 2;
			Attributes.SpellDamage = 10;
			Attributes.RegenMana = 5;
			Attributes.LowerManaCost = 6;
		}

		public VampArms( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Weight == 1.0 )
				Weight = 15.0;
		}
		public override void OnDoubleClick( Mobile from )
		{
			Item z = from.Backpack.FindItemByType( typeof(VampArms) );
			if ( z !=null )
			{
			
				if( this.ItemID == 5198 ) this.ItemID = 5102;
				else if( this.ItemID == 5102 ) this.ItemID = 5136;
				else if( this.ItemID == 5136 ) this.ItemID = 10112;
				else if( this.ItemID == 10112 ) this.ItemID = 10110;
				else if( this.ItemID == 10110 ) this.ItemID = 5069;
				else if( this.ItemID == 5069 ) this.ItemID = 5198;
			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to morph it." ); 
                        } 
		}
	}
}