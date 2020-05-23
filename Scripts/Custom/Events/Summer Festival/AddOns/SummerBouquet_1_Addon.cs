
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
	public class SummerBouquet_1_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3233, 0, 0, 5}, {3231, 0, 0, 3}// 2	4	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SummerBouquet_1_AddonDeed();
			}
		}

		[ Constructable ]
		public SummerBouquet_1_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 41185, 0, 0, 7, 16, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6093, 0, 0, 7, 0, -1, "flowers", 1);// 3
			AddComplexComponent( (BaseAddon) this, 10299, 0, 0, 15, 2728, -1, "Christmas Planter", 1);// 5
			AddComplexComponent( (BaseAddon) this, 10299, 1, 0, 14, 2728, -1, "Christmas Planter", 1);// 6
			AddComplexComponent( (BaseAddon) this, 10299, 0, 1, 13, 2728, -1, "Christmas Planter", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3224, 0, 0, 3, 0, -1, "Christmas Planter", 1);// 8
			AddComplexComponent( (BaseAddon) this, 16678, 0, 0, 0, 193, -1, "Christmas Planter", 1);// 9

		}

		public SummerBouquet_1_Addon( Serial serial ) : base( serial )
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

	public class SummerBouquet_1_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SummerBouquet_1_Addon();
			}
		}

		[Constructable]
		public SummerBouquet_1_AddonDeed()
		{
			Name = "SummerBouquet_1_";
		}

		public SummerBouquet_1_AddonDeed( Serial serial ) : base( serial )
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