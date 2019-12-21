
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
	
	public class VampChest : BoneChest
	{
		public override int BasePhysicalResistance{ get{ return 11; } }
		public override int BaseFireResistance{ get{ return 11; } }
		public override int BaseColdResistance{ get{ return 11; } }
		public override int BasePoisonResistance{ get{ return 11; } }
		public override int BaseEnergyResistance{ get{ return 11; } }

		public override int ArtifactRarity{ get{ return 6; } }

		public override int InitMinHits{ get{ return 1000; } }
		public override int InitMaxHits{ get{ return 1000; } }

		public override int AosStrReq{ get{ return 90; } }
		public override int OldStrReq{ get{ return 90; } }

		public override int OldDexBonus{ get{ return -8; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Bone; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }


		[Constructable]
		public VampChest()
		{
			ItemID = 5199;
			Weight = 10.0;
			Name = "Lamia Arca";
			Hue = 37;
			LootType = LootType.Blessed;
			Attributes.ReflectPhysical = 5;
			Attributes.CastSpeed = 1;
			Attributes.CastRecovery = 2;
			Attributes.SpellDamage = 10;
			Attributes.RegenMana = 5;
			Attributes.LowerManaCost = 6;
			Attributes.BonusStr = 5;
			Attributes.BonusDex = 10;
			Attributes.BonusInt = 10;
		}

		public VampChest( Serial serial ) : base( serial )
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
		}
		public override void OnDoubleClick( Mobile from )
		{
			Item y = from.Backpack.FindItemByType( typeof(VampChest) );
			if ( y !=null )
			{	
			
				if( this.ItemID == 5199 ) this.ItemID = 5100;
				else if( this.ItemID == 5100 ) this.ItemID = 5055;
				else if( this.ItemID == 5055 ) this.ItemID = 5141;
				else if( this.ItemID == 5141 ) this.ItemID = 7172;
				else if( this.ItemID == 7172 ) this.ItemID = 10109;
				else if( this.ItemID == 10109 ) this.ItemID = 10182;
				else if( this.ItemID == 10182 ) this.ItemID = 5068;
				else if( this.ItemID == 5068 ) this.ItemID = 10131;
				else if( this.ItemID == 10131 ) this.ItemID = 5199;
			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to morph it." ); 
                        }
		}
	}
}