
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Items;

namespace Server.Items
{
	public class VampGorget : LeatherGorget
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

		public override int OldDexBonus{ get{ return -1; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public VampGorget()
		{
			ItemID = 5063;
			Weight = 2.0;
			Name = "Lamia Iugulo";
			Hue = 37;
			LootType = LootType.Blessed;
			Attributes.ReflectPhysical = 5;
			Attributes.CastSpeed = 1;
			Attributes.CastRecovery = 2;
			Attributes.SpellDamage = 10;
			Attributes.RegenMana = 5;
			Attributes.LowerManaCost = 6;
		}

		public VampGorget( Serial serial ) : base( serial )
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
			Item v = from.Backpack.FindItemByType( typeof(VampGorget) );
			if ( v !=null )
			{
			
				if( this.ItemID == 5063 ) this.ItemID = 5139;
				else if( this.ItemID == 5139 ) this.ItemID = 10105;
				else if( this.ItemID == 10105 ) this.ItemID = 10106;
				else if( this.ItemID == 10106 ) this.ItemID = 7944;
				else if( this.ItemID == 7944 ) this.ItemID = 4229;
				else if( this.ItemID == 4229 ) this.ItemID = 5063;
			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to morph it." ); 
                        } 
		}	
	}
}