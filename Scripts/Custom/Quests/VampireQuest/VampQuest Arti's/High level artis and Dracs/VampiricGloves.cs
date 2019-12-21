using System;
using Server.Items;


//////////////////////////
//Created by LostSinner//
////////////////////////
namespace Server.Items
{

	public class VampGloves : BoneGloves
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
		public VampGloves()
		{
			ItemID = 5200;
			Weight = 2.0;
			Name = "Lamia Attrecto";
			Hue = 37;
			LootType = LootType.Blessed;
			Attributes.ReflectPhysical = 5;
			Attributes.CastSpeed = 1;
			Attributes.CastRecovery = 2;
			Attributes.SpellDamage = 10;
			Attributes.RegenMana = 5;
			Attributes.LowerManaCost = 6;
		}

		public VampGloves( Serial serial ) : base( serial )
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
				Weight = 2.0;
		}
		public override void OnDoubleClick( Mobile from )
		{
			Item w = from.Backpack.FindItemByType( typeof(VampGloves) );
			if ( w !=null )
			{
			
				if( this.ItemID == 5200 ) this.ItemID = 5099;
				else if( this.ItemID == 5099 ) this.ItemID = 5140;
				else if( this.ItemID == 5140 ) this.ItemID = 5062;
				else if( this.ItemID == 5062 ) this.ItemID = 10130;
				else if( this.ItemID == 10130 ) this.ItemID = 5200;
			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to morph it." ); 
                        }
		}
	}
}