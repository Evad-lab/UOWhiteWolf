
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
	public class HydrangeaBush_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HydrangeaBush_AddonDeed();
			}
		}

		[ Constructable ]
		public HydrangeaBush_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 3512, 0, 0, 0, 0, -1, "Hydrangea Bush", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 8, 2729, -1, "Hydrangea Bush", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 11, 2729, -1, "Hydrangea Bush", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 14, 2729, -1, "Hydrangea Bush", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 5, 2729, -1, "Hydrangea Bush", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 2, 2729, -1, "Hydrangea Bush", 1);// 6

		}

		public HydrangeaBush_Addon( Serial serial ) : base( serial )
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

	public class HydrangeaBush_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HydrangeaBush_Addon();
			}
		}

		[Constructable]
		public HydrangeaBush_AddonDeed()
		{
			Name = "HydrangeaBush_";
		}

		public HydrangeaBush_AddonDeed( Serial serial ) : base( serial )
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