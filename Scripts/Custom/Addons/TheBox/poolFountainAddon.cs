
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
	public class poolFountainAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3237, 1, -2, 2}, {3261, 3, -3, 0}, {3517, -1, 0, 2}// 1	2	3	
			, {3336, 3, 0, 5}, {6049, 1, 3, 0}, {6053, 4, -1, 0}// 4	5	6	
			, {13430, 0, -1, 0}, {3332, 4, 1, 1}, {3231, 1, -3, 1}// 7	9	10	
			, {3332, 1, 3, 2}, {4964, 3, 2, 0}, {7038, -2, -3, 0}// 11	12	13	
			, {6809, 4, -2, 0}, {13429, 0, -2, 0}, {6058, 2, 2, 0}// 14	15	16	
			, {6045, 2, 2, 0}, {13429, 1, -2, 0}, {6045, 3, -1, 0}// 17	18	19	
			, {3211, -2, 0, 1}, {6002, -1, -1, 0}, {6053, 2, -3, 0}// 20	22	23	
			, {13446, 1, 0, 15}, {7038, -2, -1, 0}, {3206, 4, 0, 1}// 24	25	26	
			, {3219, 3, -1, 0}, {6046, 4, 0, 0}, {3257, 4, 2, 0}// 27	28	29	
			, {3256, 2, 3, 5}, {13430, 2, 1, 0}, {4967, -2, 1, 0}// 30	31	32	
			, {3223, 3, 3, 3}, {13429, -1, 0, 0}, {3212, 2, -3, 0}// 33	34	35	
			, {6049, 0, 2, 0}, {3208, 4, -2, 0}, {13429, 1, 2, 0}// 36	37	38	
			, {6058, 3, 1, 0}, {6809, 1, 3, 2}, {4967, 4, -1, 0}// 39	40	41	
			, {3517, 1, 2, 3}, {3212, 3, -2, 0}, {3272, -3, 0, 0}// 42	43	44	
			, {13430, 1, 1, 0}, {13487, 0, 0, 2}, {6049, -1, 1, 0}// 46	47	48	
			, {3333, 2, -2, 0}, {3220, -1, -3, 0}, {3255, 3, 1, 1}// 49	50	51	
			, {6045, 3, 1, 0}, {6051, -2, 0, 0}, {13430, 1, 0, 0}// 52	53	54	
			, {13429, 3, 0, 0}, {6045, 2, -2, 0}, {6002, 0, -2, 0}// 55	56	57	
			, {13430, 1, -1, 0}, {13484, 0, 0, 5}, {3333, 0, 2, 0}// 58	59	60	
			, {13430, 2, 0, 0}, {6047, 1, -3, 0}, {3518, 3, 0, 3}// 61	62	63	
			, {13489, 1, 0, 2}, {3210, -2, 2, 1}, {13430, 2, -1, 0}// 64	65	66	
			, {13430, 0, 0, 0}, {9036, -1, -1, 3}, {3220, 0, 3, 0}// 67	68	69	
			, {3246, 4, 0, 0}, {4955, -1, -2, 0}, {3220, -2, -2, 0}// 70	71	72	
			, {13430, 0, 1, 0}, {7038, 0, -3, 0}, {6006, 0, -1, 0}// 73	74	75	
			, {4963, 3, -2, 0}, {13451, 1, 0, 9}, {3203, -1, 2, 0}// 76	77	78	
			, {2541, 0, -1, 9}// 79	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new poolFountainAddonDeed();
			}
		}

		[ Constructable ]
		public poolFountainAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6186, 1, 0, 13, 1151, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2416, 0, -1, 14, 294, -1, "water", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2416, 0, -1, 9, 294, -1, "water", 1);// 45

		}

		public poolFountainAddon( Serial serial ) : base( serial )
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

	public class poolFountainAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new poolFountainAddon();
			}
		}

		[Constructable]
		public poolFountainAddonDeed()
		{
			Name = "poolFountain";
		}

		public poolFountainAddonDeed( Serial serial ) : base( serial )
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