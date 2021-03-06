
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
	public class BathroomVanityEast_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BathroomVanityEast_AddonDeed();
			}
		}

		[ Constructable ]
		public BathroomVanityEast_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 699, 0, -1, 8, 0, -1, "Vanity", 1);// 1
			AddComplexComponent( (BaseAddon) this, 699, 0, 1, 8, 0, -1, "Vanity", 1);// 2
			AddComplexComponent( (BaseAddon) this, 699, 1, -1, 8, 0, -1, "Vanity", 1);// 3
			AddComplexComponent( (BaseAddon) this, 699, 1, 1, 8, 0, -1, "soaker tub", 1);// 4
			AddComplexComponent( (BaseAddon) this, 16453, 1, 0, 18, 0, -1, "Vanity Mirror", 1);// 5
			AddComplexComponent( (BaseAddon) this, 13477, 1, 0, 9, 0, -1, "Vanity", 1);// 6
			AddComplexComponent( (BaseAddon) this, 698, 1, -1, 8, 0, -1, "Vanity", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1801, 1, 1, 3, 1153, -1, "Vanity", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 3, 1153, -1, "Vanity", 1);// 9
			AddComplexComponent( (BaseAddon) this, 699, 0, 0, 8, 0, -1, "Vanity", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2552, 1, 0, 14, 0, -1, "handle", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4100, 1, 0, 18, 0, -1, "faucet", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1300, 1, -1, 12, 1153, -1, "Vanity", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1300, 1, 1, 12, 1153, -1, "Vanity", 1);// 14
			AddComplexComponent( (BaseAddon) this, 699, 1, 0, 8, 0, -1, "Vanity", 1);// 15
			AddComplexComponent( (BaseAddon) this, 699, 1, 1, 0, 0, -1, "soaker tub", 1);// 16
			AddComplexComponent( (BaseAddon) this, 699, 1, -1, 0, 0, -1, "soaker tub", 1);// 17
			AddComplexComponent( (BaseAddon) this, 698, 1, 1, 0, 0, -1, "Vanity", 1);// 18
			AddComplexComponent( (BaseAddon) this, 698, 1, -1, 0, 0, -1, "Vanity", 1);// 19
			AddComplexComponent( (BaseAddon) this, 698, 1, 1, 8, 0, -1, "Vanity", 1);// 20

		}

		public BathroomVanityEast_Addon( Serial serial ) : base( serial )
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

	public class BathroomVanityEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BathroomVanityEast_Addon();
			}
		}

		[Constructable]
		public BathroomVanityEast_AddonDeed()
		{
			Name = "BathroomVanityEast_";
		}

		public BathroomVanityEast_AddonDeed( Serial serial ) : base( serial )
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