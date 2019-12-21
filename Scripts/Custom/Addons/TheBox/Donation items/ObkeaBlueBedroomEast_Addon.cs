
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
	public class ObkeaBlueBedroomEast_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9444, 3, 0, 10}, {10314, -2, 2, 2}, {10314, -2, -2, 2}// 8	9	10	
			, {1981, 3, 2, 0}, {1981, 3, 1, 0}, {1981, 3, 0, 0}// 19	20	21	
			, {1981, 3, -1, 0}, {1981, 3, -2, 0}, {9234, -2, 2, 2}// 22	23	36	
			, {9234, -2, -2, 2}, {1981, 2, 2, 0}, {1981, 2, 1, 0}// 37	43	44	
			, {1981, 2, 0, 0}, {1981, 2, -1, 0}, {1981, 2, -2, 0}// 45	46	47	
			, {1981, 1, -2, 0}, {1981, 1, -1, 0}, {1981, 1, 0, 0}// 48	49	50	
			, {1981, 1, 1, 0}, {1981, 1, 2, 0}, {1981, 0, 2, 0}// 51	52	53	
			, {1981, 0, 1, 0}, {1981, 0, 0, 0}, {1981, 0, -1, 0}// 54	55	56	
			, {1981, 0, -2, 0}, {1981, -1, -2, 0}, {1981, -1, -1, 0}// 57	58	59	
			, {1981, -1, 0, 0}, {1981, -1, 1, 0}, {1981, -1, 2, 0}// 60	61	62	
			, {1981, -2, 2, 0}, {1981, -2, 1, 0}, {1981, -2, 0, 0}// 63	64	65	
			, {1981, -2, -1, 0}, {1981, -2, -2, 0}// 66	67	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ObkeaBlueBedroomEast_AddonDeed();
			}
		}

		[ Constructable ]
		public ObkeaBlueBedroomEast_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3530, 2, -1, 7, 1153, -1, "grandma's crocheted afghan", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5036, -1, 0, 8, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5028, -1, 1, 8, 601, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 5028, -1, -1, 8, 601, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 5028, -1, 0, 7, 601, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 5690, -1, 1, 7, 1928, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5690, -1, -1, 7, 1928, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 38971, 3, 1, 2, 0, 2, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 10264, 3, 0, 2, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3530, 2, 1, 7, 1153, -1, "grandma's crocheted afghan", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3530, 2, 0, 7, 1153, -1, "grandma's crocheted afghan", 1);// 14
			AddComplexComponent( (BaseAddon) this, 10330, -2, 1, 2, 601, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10330, -2, 0, 7, 601, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10330, -2, 0, 2, 601, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10330, -2, -1, 2, 601, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1801, 2, -1, 2, 2122, -1, "bed", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1801, 2, 0, 2, 2122, -1, "bed", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1801, 2, 1, 2, 2122, -1, "bed", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1801, 1, 1, 2, 2122, -1, "bed", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1801, 1, 0, 2, 2122, -1, "bed", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 2, 2122, -1, "bed", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 2, 2122, -1, "bed", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1801, 0, -1, 2, 2122, -1, "bed", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1801, 0, 1, 2, 2122, -1, "bed", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 2, 2122, -1, "bed", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 2, 2122, -1, "bed", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 2, 2122, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 5645, -2, 2, 2, 1928, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5645, -2, 1, 2, 1928, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5645, -2, 0, 2, 1928, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 5645, -2, -1, 2, 1928, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 5645, -2, -2, 2, 1928, -1, "", 1);// 42

		}

		public ObkeaBlueBedroomEast_Addon( Serial serial ) : base( serial )
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

	public class ObkeaBlueBedroomEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ObkeaBlueBedroomEast_Addon();
			}
		}

		[Constructable]
		public ObkeaBlueBedroomEast_AddonDeed()
		{
			Name = "ObkeaBlueBedroomEast_";
		}

		public ObkeaBlueBedroomEast_AddonDeed( Serial serial ) : base( serial )
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