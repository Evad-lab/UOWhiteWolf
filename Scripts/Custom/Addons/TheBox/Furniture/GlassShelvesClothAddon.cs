
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class GlassShelvesClothAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GlassShelvesClothAddonDeed();
			}
		}

		[ Constructable ]
		public GlassShelvesClothAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 0, 0, -1, "table", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 0, 0, -1, "table", 1);// 2
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 4, 1150, -1, "frosted glass", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 4, 0, -1, "table", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 4, 0, -1, "table", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 8, 1150, -1, "frosted glass", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 5, 25, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 7, 188, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 8, 0, -1, "table", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 8, 0, -1, "table", 1);// 10
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 12, 1150, -1, "frosted glass", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 11, 1161, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 12, 0, -1, "table", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 12, 0, -1, "table", 1);// 14
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 16, 1150, -1, "frosted glass", 1);// 15
			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 16, 1153, -1, "", 1);// 16

		}

		public GlassShelvesClothAddon( Serial serial ) : base( serial )
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

	public class GlassShelvesClothAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GlassShelvesClothAddon();
			}
		}

		[Constructable]
		public GlassShelvesClothAddonDeed()
		{
			Name = "GlassShelvesCloth";
		}

		public GlassShelvesClothAddonDeed( Serial serial ) : base( serial )
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