
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
	public class LamppostBlackRedIIAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LamppostBlackRedIIAddonDeed();
			}
		}

		[ Constructable ]
		public LamppostBlackRedIIAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2852, 0, 0, 0, 0, 1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4175, 0, 0, 14, 33, -1, "morning glory", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4176, 0, 0, 12, 33, -1, "morning glories'", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6375, 0, 0, 8, 1, -1, "vine", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4176, 0, 0, 3, 33, -1, "morning glories", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6376, 0, 0, 14, 1, -1, "vine", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4180, 0, 0, 16, 33, -1, "morning glories", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6375, 0, 0, 1, 1, -1, "vine", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4175, 0, 0, 8, 33, -1, "morning glories", 1);// 9

		}

		public LamppostBlackRedIIAddon( Serial serial ) : base( serial )
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

	public class LamppostBlackRedIIAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LamppostBlackRedIIAddon();
			}
		}

		[Constructable]
		public LamppostBlackRedIIAddonDeed()
		{
			Name = "LamppostBlackRedII";
		}

		public LamppostBlackRedIIAddonDeed( Serial serial ) : base( serial )
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