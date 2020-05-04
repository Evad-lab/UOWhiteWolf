
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
	public class BKitchenSinkSouth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13477, 0, 1, 6}, {2519, 2, 0, 11}, {2519, 2, 0, 9}// 1	7	8	
			, {2519, 2, 0, 7}, {13477, 1, 1, 6}, {6812, -1, 1, 9}// 9	14	32	
			, {2519, -1, 0, 11}, {2519, -1, 0, 9}, {2519, -1, 0, 7}// 33	34	35	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BKitchenSinkSouth_AddonDeed();
			}
		}

		[ Constructable ]
		public BKitchenSinkSouth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5535, 0, 0, 0, 53, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5535, 1, 0, 0, 53, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41246, 1, 0, 11, 25, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7192, 0, 0, 9, 2969, -1, "Palmolive", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4101, 1, 0, 10, 0, -1, "comet", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1113, 2, 0, 12, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1113, 2, 0, 10, 1153, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1113, 2, 0, 8, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1113, 2, 0, 6, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 699, 0, 1, 6, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 699, 1, 1, 6, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 698, 1, 0, 6, 1153, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 698, 0, 0, 6, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 698, 1, 1, 6, 1153, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 698, 0, 1, 6, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1300, 2, 0, 6, 1153, -1, "tile counter", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1300, 2, 1, 6, 1153, -1, "tile counter", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1300, 1, 0, 6, 1153, -1, "tile counter", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1300, 0, 0, 6, 1153, -1, "tile counter", 1);// 24
			AddComplexComponent( (BaseAddon) this, 19207, 2, 0, 0, 1310, -1, "counter", 1);// 25
			AddComplexComponent( (BaseAddon) this, 19207, 1, 0, 0, 1310, -1, "counter", 1);// 26
			AddComplexComponent( (BaseAddon) this, 19207, 0, 0, 0, 1310, -1, "counter", 1);// 27
			AddComplexComponent( (BaseAddon) this, 19207, 2, 1, 0, 1310, -1, "counter", 1);// 28
			AddComplexComponent( (BaseAddon) this, 19207, 1, 1, 0, 1310, -1, "counter", 1);// 29
			AddComplexComponent( (BaseAddon) this, 19207, 0, 1, 0, 1310, -1, "counter", 1);// 30
			AddComplexComponent( (BaseAddon) this, 6420, -1, 0, 17, 88, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1113, -1, 0, 12, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1113, -1, 0, 10, 1153, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1113, -1, 0, 8, 1153, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1113, -1, 0, 6, 1153, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 699, -1, 1, 6, 1153, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1300, -1, 1, 6, 1153, -1, "tile counter", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1300, -1, 0, 6, 1153, -1, "tile counter", 1);// 42
			AddComplexComponent( (BaseAddon) this, 19207, -1, 0, 0, 1310, -1, "counter", 1);// 43
			AddComplexComponent( (BaseAddon) this, 19207, -1, 1, 0, 1310, -1, "counter", 1);// 44

		}

		public BKitchenSinkSouth_Addon( Serial serial ) : base( serial )
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

	public class BKitchenSinkSouth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BKitchenSinkSouth_Addon();
			}
		}

		[Constructable]
		public BKitchenSinkSouth_AddonDeed()
		{
			Name = "BKitchenSinkSouth_";
		}

		public BKitchenSinkSouth_AddonDeed( Serial serial ) : base( serial )
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