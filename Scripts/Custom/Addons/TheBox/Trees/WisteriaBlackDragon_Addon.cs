
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class WisteriaBlackDragon_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WisteriaBlackDragon_AddonDeed();
			}
		}

		[ Constructable ]
		public WisteriaBlackDragon_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 41247, 0, 1, 13, 22, -1, "Wisteria Tree", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41247, -1, 2, 14, 22, -1, "Wisteria Tree", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41247, -1, 2, 20, 22, -1, "Wisteria Tree", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41247, 0, 0, 13, 22, -1, "Wisteria Tree", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41247, 1, 0, 13, 22, -1, "Wisteria Tree", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41247, 1, -1, 15, 22, -1, "Wisteria Tree", 1);// 6
			AddComplexComponent( (BaseAddon) this, 41247, 1, -1, 20, 22, -1, "Wisteria Tree", 1);// 7
			AddComplexComponent( (BaseAddon) this, 41247, 1, -1, 8, 22, -1, "Wisteria Tree", 1);// 8
			AddComplexComponent( (BaseAddon) this, 41247, 2, -1, 21, 22, -1, "Wisteria Tree", 1);// 9
			AddComplexComponent( (BaseAddon) this, 41247, 1, 0, 25, 22, -1, "Wisteria Tree", 1);// 10
			AddComplexComponent( (BaseAddon) this, 41247, 0, 0, 19, 22, -1, "Wisteria Tree", 1);// 11
			AddComplexComponent( (BaseAddon) this, 41247, 0, 2, 25, 22, -1, "Wisteria Tree", 1);// 12
			AddComplexComponent( (BaseAddon) this, 41247, 0, 1, 28, 22, -1, "Wisteria Tree", 1);// 13
			AddComplexComponent( (BaseAddon) this, 41247, -1, 2, 7, 22, -1, "Wisteria Tree", 1);// 14
			AddComplexComponent( (BaseAddon) this, 41247, 0, 2, 32, 22, -1, "Wisteria Tree", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3293, 0, 0, 0, 0, -1, "Wisteria Tree", 1);// 16

		}

		public WisteriaBlackDragon_Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class WisteriaBlackDragon_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WisteriaBlackDragon_Addon();
			}
		}

		[Constructable]
		public WisteriaBlackDragon_AddonDeed()
		{
			Name = "WisteriaBlackDragon_";
		}

		public WisteriaBlackDragon_AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}