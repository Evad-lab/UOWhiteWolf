
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
	public class ThornPlant1_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9037, 0, 0, 9}, {17650, 0, 0, 1}// 8	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ThornPlant1_AddonDeed();
			}
		}

		[ Constructable ]
		public ThornPlant1_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6093, 1, 1, 15, 0, -1, "flowers", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41258, 0, 1, 10, 53, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41257, 1, 0, 10, 53, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41257, 1, 1, 13, 53, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41258, 1, 1, 18, 53, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41257, 0, 1, 15, 53, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 41258, 1, 0, 13, 53, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 22320, 0, 0, 4, 567, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 6, 16, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 39696, 0, 0, 0, 1153, -1, "", 1);// 12

		}

		public ThornPlant1_Addon( Serial serial ) : base( serial )
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

	public class ThornPlant1_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ThornPlant1_Addon();
			}
		}

		[Constructable]
		public ThornPlant1_AddonDeed()
		{
			Name = "ThornPlant1_";
		}

		public ThornPlant1_AddonDeed( Serial serial ) : base( serial )
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