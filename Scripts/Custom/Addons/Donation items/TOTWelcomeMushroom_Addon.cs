
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
	public class ToTWelcomeMushroom_Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ToTWelcomeMushroom_AddonDeed();
			}
		}

		[ Constructable ]
		public ToTWelcomeMushroom_Addon()
		{



			AddComplexComponent( (BaseAddon) this, 3265, 2, 0, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3350, -2, 1, 2, 0, -1, "Welcome to The Obsidian Tales", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3349, -2, 1, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3347, 1, 1, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41249, -1, 2, 2, 16, -1, "Welcome to The Obsidian Tales", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41252, -1, 2, 1, 53, -1, "Welcome to The Obsidian Tales", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3236, 1, 1, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3231, 0, -1, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3210, 1, -1, 4, 0, -1, "Welcome to The Obsidian Tales", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3210, -2, 0, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3235, -1, 0, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3231, -1, 1, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 12
			AddComplexComponent( (BaseAddon) this, 41247, 1, 0, 1, 23, -1, "Welcome to The Obsidian Tales", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3224, 0, 0, 0, 0, -1, "Welcome to The Obsidian Tales", 1);// 14
			AddComplexComponent( (BaseAddon) this, 41187, 0, 1, 1, 11, -1, "Welcome to The Obsidian Tales", 1);// 15
			AddComplexComponent( (BaseAddon) this, 6093, 0, 1, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 16
			AddComplexComponent( (BaseAddon) this, 6093, 1, 0, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3235, 1, 0, 1, 0, -1, "Welcome to The Obsidian Tales", 1);// 18
			AddComplexComponent( (BaseAddon) this, 8751, 0, 0, 3, 0, -1, "Welcome to The Obsidian Tales", 1);// 19

		}

		public ToTWelcomeMushroom_Addon( Serial serial ) : base( serial )
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

	public class ToTWelcomeMushroom_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ToTWelcomeMushroom_Addon();
			}
		}

		[Constructable]
		public ToTWelcomeMushroom_AddonDeed()
		{
			Name = "ToTWelcomeMushroom_";
		}

		public ToTWelcomeMushroom_AddonDeed( Serial serial ) : base( serial )
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