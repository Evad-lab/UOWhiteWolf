
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
	public class BBQEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1822, 0, -3, 3}, {1822, 0, -2, 4}, {1822, 0, -1, 6}// 4	5	6	
			, {1822, 0, -1, 2}, {1822, 1, -1, 0}, {1822, 1, -1, 2}// 7	8	9	
			, {2421, 1, -2, 6}, {2416, 1, -2, 14}, {1822, 1, -2, 0}// 10	11	12	
			, {4329, 1, -3, 7}, {1822, 1, -3, 0}, {1822, 1, -3, 2}// 13	14	15	
			, {5625, 0, -2, 9}, {5637, 0, -3, 7}, {1822, 0, -1, 2}// 16	17	18	
			, {2449, 1, 2, 7}, {1822, 1, 2, 0}, {1822, 1, 2, 2}// 19	20	21	
			, {5111, 1, 2, 9}, {1822, 1, 1, 0}, {1822, 0, 0, 6}// 22	23	24	
			, {1822, 0, 0, 2}, {1822, 1, 0, 0}, {1822, 0, 1, 4}// 25	26	27	
			, {1822, 0, 2, 0}, {1822, 0, 2, 3}, {5628, 0, 1, 9}// 28	29	30	
			, {5634, 0, 0, 11}, {1822, 0, 2, 0}, {1822, 0, 0, 2}// 31	32	33	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BBQEastAddonDeed();
			}
		}

		[ Constructable ]
		public BBQEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6580, 1, 1, 0, 0, 1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6580, 1, 0, 0, 0, 1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6580, 1, -2, 0, 0, 1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4846, 1, -2, 5, 0, 2, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 4846, 1, 1, 5, 0, 2, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 4846, 1, 0, 5, 0, 2, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 6467, 1, -1, 4, 0, -1, "Imported Spices", 1);// 37
			AddComplexComponent( (BaseAddon) this, 3530, 1, -2, 6, 1, -1, "Grill", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2459, 0, -1, 11, 0, -1, "Cooking Wine", 1);// 39
			AddComplexComponent( (BaseAddon) this, 7138, 1, 3, 0, 0, -1, "Mesquite Logs", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2518, 0, 2, 8, 0, -1, "Marinade", 1);// 41
			AddComplexComponent( (BaseAddon) this, 3530, 1, 1, 6, 1, -1, "Grill", 1);// 42
			AddComplexComponent( (BaseAddon) this, 3530, 1, 0, 6, 1, -1, "Grill", 1);// 43
			AddComplexComponent( (BaseAddon) this, 7703, 1, 1, 7, 0, -1, "Grilled Salmon", 1);// 44
			AddComplexComponent( (BaseAddon) this, 7703, 1, 0, 7, 0, -1, "Grilled Salmon", 1);// 45

		}

		public BBQEastAddon( Serial serial ) : base( serial )
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

	public class BBQEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BBQEastAddon();
			}
		}

		[Constructable]
		public BBQEastAddonDeed()
		{
			Name = "BBQEast";
		}

		public BBQEastAddonDeed( Serial serial ) : base( serial )
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