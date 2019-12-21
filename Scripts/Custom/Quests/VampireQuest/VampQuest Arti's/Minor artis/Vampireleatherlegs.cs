
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x13cb, 0x13d2 )]
	public class VampireLeatherLegs : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 14; } }
		public override int BaseFireResistance{ get{ return 14; } }
		public override int BaseColdResistance{ get{ return 14; } }
		public override int BasePoisonResistance{ get{ return 14; } }
		public override int BaseEnergyResistance{ get{ return 14; } }

		public override int InitMinHits{ get{ return 30; } }
		public override int InitMaxHits{ get{ return 40; } }

		public override int AosDexReq{ get{ return 65; } }
		public override int AosStrReq{ get{ return 20; } }
		public override int OldStrReq{ get{ return 10; } }

		public override int ArmorBase{ get{ return 13; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public VampireLeatherLegs() : base( 0x13CB )
		{
			Weight = 4.0;
			Hue = 37;
			Name = "Vampire Leggins";
		}

		public VampireLeatherLegs( Serial serial ) : base( serial )
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
	}
}
