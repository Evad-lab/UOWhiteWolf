
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
	public class ChristmasPlanterPurple_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ChristmasPlanterPurple_AddonDeed();
			}
		}

		[ Constructable ]
		public ChristmasPlanterPurple_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 3136, 1, 1, 8, 11, -1, "Christmas Planter", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3136, 0, 1, 0, 11, -1, "Christmas Planter", 1);// 2
			AddComplexComponent( (BaseAddon) this, 10299, 0, 0, 12, 2728, -1, "Christmas Planter", 1);// 3
			AddComplexComponent( (BaseAddon) this, 10299, 0, 1, 10, 2728, -1, "Christmas Planter", 1);// 4
			AddComplexComponent( (BaseAddon) this, 10299, 1, 0, 12, 2728, -1, "Christmas Planter", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6093, 0, 0, 11, 0, -1, "Christmas Planter", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3152, 0, 0, 6, 1153, -1, "Christmas Planter", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3268, 0, 0, 9, 14, -1, "Christmas Planter", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3224, 0, 0, 3, 14, -1, "Christmas Planter", 1);// 9
			AddComplexComponent( (BaseAddon) this, 16678, 0, 0, 2, 2498, -1, "Christmas Planter", 1);// 10

		}

		public ChristmasPlanterPurple_Addon( Serial serial ) : base( serial )
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

	public class ChristmasPlanterPurple_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ChristmasPlanterPurple_Addon();
			}
		}

		[Constructable]
		public ChristmasPlanterPurple_AddonDeed()
		{
			Name = "ChristmasPlanterPurple_";
		}

		public ChristmasPlanterPurple_AddonDeed( Serial serial ) : base( serial )
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