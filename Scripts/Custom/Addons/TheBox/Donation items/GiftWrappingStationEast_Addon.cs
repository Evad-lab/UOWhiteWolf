
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
	public class GiftWrappingStationEast_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {40837, 1, -1, 0}, {39570, 1, 1, 0}, {2879, 0, 1, 0}// 4	11	17	
			, {2877, 0, -1, 0}, {2879, 0, -2, 0}, {2877, 0, 0, 0}// 18	19	22	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GiftWrappingStationEast_AddonDeed();
			}
		}

		[ Constructable ]
		public GiftWrappingStationEast_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 19675, 1, -2, 6, 73, -1, "green ribbon", 1);// 1
			AddComplexComponent( (BaseAddon) this, 19675, 1, -2, 3, 1153, -1, "white ribbon", 1);// 2
			AddComplexComponent( (BaseAddon) this, 19675, 1, -2, 0, 33, -1, "red ribbon", 1);// 3
			AddComplexComponent( (BaseAddon) this, 18085, 0, -1, 9, 1172, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 18084, 0, 2, 0, 1173, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9003, 0, 1, 8, 32, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3581, 0, -1, 10, 0, -1, "Paper Cutting Scissors", 1);// 8
			AddComplexComponent( (BaseAddon) this, 18084, 0, 2, 2, 1931, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 18084, 1, 2, 0, 1173, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4152, 1, 0, 0, 1153, -1, "paper scraps", 1);// 12
			AddComplexComponent( (BaseAddon) this, 18086, 1, 2, 2, 1284, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4029, 0, 0, 6, 0, -1, "the nice list", 1);// 14
			AddComplexComponent( (BaseAddon) this, 18084, 0, 2, 4, 1195, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 18083, 0, -2, 10, 1194, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9002, 0, -2, 7, 562, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2602, 1, 0, 0, 33, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 9003, 1, 1, 4, 311, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 9003, -1, -2, 4, 38, -1, "", 1);// 24

		}

		public GiftWrappingStationEast_Addon( Serial serial ) : base( serial )
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

	public class GiftWrappingStationEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GiftWrappingStationEast_Addon();
			}
		}

		[Constructable]
		public GiftWrappingStationEast_AddonDeed()
		{
			Name = "GiftWrappingStationEast_";
		}

		public GiftWrappingStationEast_AddonDeed( Serial serial ) : base( serial )
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