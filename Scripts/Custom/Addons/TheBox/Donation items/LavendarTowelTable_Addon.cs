
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
	public class LavendarTowelTable_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LavendarTowelTable_AddonDeed();
			}
		}

		[ Constructable ]
		public LavendarTowelTable_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 6420, 0, 0, 6, 16, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6420, 0, 0, 4, 16, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 4, 1150, -1, "frosted glass", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 0, 0, -1, "table", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 0, 0, -1, "table", 1);// 5

		}

		public LavendarTowelTable_Addon( Serial serial ) : base( serial )
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

	public class LavendarTowelTable_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LavendarTowelTable_Addon();
			}
		}

		[Constructable]
		public LavendarTowelTable_AddonDeed()
		{
			Name = "LavendarTowelTable_";
		}

		public LavendarTowelTable_AddonDeed( Serial serial ) : base( serial )
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