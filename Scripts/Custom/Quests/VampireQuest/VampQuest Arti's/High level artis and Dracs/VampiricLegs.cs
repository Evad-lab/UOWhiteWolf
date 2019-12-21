
//////////////////////////
//Created by LostSinner//
////////////////////////using System;
using Server.Items;

namespace Server.Items
{
	
	
	public class VampLegs : BoneLegs
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

		public override int OldDexBonus{ get{ return -6; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Bone; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public VampLegs()
		{
			ItemID = 5202;
			Weight = 6.0;
			Name = "Lamia Articulus";
			Hue = 37;
			LootType = LootType.Blessed;
			Attributes.ReflectPhysical = 5;
			Attributes.CastSpeed = 1;
			Attributes.CastRecovery = 2;
			Attributes.SpellDamage = 10;
			Attributes.RegenMana = 5;
			Attributes.LowerManaCost = 6;
		}

		public VampLegs( Serial serial ) : base( serial )
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
			
			Item t = from.Backpack.FindItemByType( typeof(VampLegs) );
			if ( t !=null )
			{
			
				if( this.ItemID == 5202 ) this.ItemID = 5104;
				else if( this.ItemID == 5104 ) this.ItemID = 5054;
				else if( this.ItemID == 5054 ) this.ItemID = 5137;
				else if( this.ItemID == 5137 ) this.ItemID = 10125;
				else if( this.ItemID == 10125 ) this.ItemID = 10120;
				else if( this.ItemID == 10120 ) this.ItemID = 10118;
				else if( this.ItemID == 10118 ) this.ItemID = 5067;
				else if( this.ItemID == 5067 ) this.ItemID = 10129;
				else if( this.ItemID == 10129 ) this.ItemID = 5202;
			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to morph it." ); 
                        }
		}
	}
}