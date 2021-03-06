
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
	public class ObkeaRedBedroomSouth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9444, 0, 3, 10}, {10314, 2, -2, 2}, {10314, -2, -2, 2}// 7	8	9	
			, {10329, 1, -2, 2}, {10329, 0, -2, 7}, {10329, 0, -2, 2}// 15	16	17	
			, {10329, -1, -2, 2}, {1981, 2, 3, 0}, {1981, 0, 3, 0}// 18	19	20	
			, {1981, 1, 3, 0}, {1981, -1, 3, 0}, {1981, -2, 3, 0}// 21	22	23	
			, {9233, 2, -2, 2}, {9233, -2, -2, 2}, {5646, 2, -2, 2}// 36	37	38	
			, {5646, 1, -2, 2}, {5646, 0, -2, 2}, {5646, -1, -2, 2}// 39	40	41	
			, {5646, -2, -2, 2}, {1981, -2, 2, 0}, {1981, -2, 1, 0}// 42	43	44	
			, {1981, -2, 0, 0}, {1981, -2, -1, 0}, {1981, -2, -2, 0}// 45	46	47	
			, {1981, 1, 0, 0}, {1981, 1, 1, 0}, {1981, 0, 1, 0}// 48	49	50	
			, {1981, 0, 0, 0}, {1981, 0, -1, 0}, {1981, 1, -1, 0}// 51	52	53	
			, {1981, 2, 1, 0}, {1981, 2, 0, 0}, {1981, 2, -1, 0}// 54	55	56	
			, {1981, 2, -2, 0}, {1981, 1, -2, 0}, {1981, 0, -2, 0}// 57	58	59	
			, {1981, -1, -2, 0}, {1981, -1, 0, 0}, {1981, -1, -1, 0}// 60	61	62	
			, {1981, -1, 1, 0}, {1981, 0, 2, 0}, {1981, -1, 2, 0}// 63	64	65	
			, {1981, 1, 2, 0}, {1981, 2, 2, 0}// 66	67	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ObkeaRedBedroomSouth_AddonDeed();
			}
		}

		[ Constructable ]
		public ObkeaRedBedroomSouth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5036, 0, -1, 8, 33, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5029, 1, -1, 8, 1944, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5029, 0, -1, 7, 1944, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 5029, -1, -1, 8, 1944, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 5690, 1, -1, 7, 237, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 5690, -1, -1, 7, 237, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 38975, 1, 3, 2, 0, 2, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 10263, 0, 3, 2, 1944, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3530, 1, 2, 7, 237, -1, "grandma's crocheted afghan", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3530, 0, 2, 7, 237, -1, "grandma's crocheted afghan", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3530, -1, 2, 7, 237, -1, "grandma's crocheted afghan", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1801, -1, 2, 2, 1944, -1, "bed", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1801, 0, 1, 2, 1944, -1, "bed", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1801, 1, 2, 2, 1944, -1, "bed", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1801, 1, 1, 2, 1944, -1, "bed", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1801, 0, 2, 2, 1944, -1, "bed", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 2, 1944, -1, "bed", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 2, 1944, -1, "bed", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1801, 0, -1, 2, 1944, -1, "bed", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1801, 1, 0, 2, 1944, -1, "bed", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 2, 1944, -1, "bed", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 2, 1944, -1, "bed", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 2, 1944, -1, "bed", 1);// 35

		}

		public ObkeaRedBedroomSouth_Addon( Serial serial ) : base( serial )
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

	public class ObkeaRedBedroomSouth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ObkeaRedBedroomSouth_Addon();
			}
		}

		[Constructable]
		public ObkeaRedBedroomSouth_AddonDeed()
		{
			Name = "ObkeaRedBedroomSouth_";
		}

		public ObkeaRedBedroomSouth_AddonDeed( Serial serial ) : base( serial )
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