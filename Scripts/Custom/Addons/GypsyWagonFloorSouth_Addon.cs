
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
	public class GypsyWagonFloorSouth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2204, 0, 4, 0}, {2204, 1, 4, 0}, {1997, 2, 3, 7}// 1	2	3	
			, {1998, -1, 2, 7}, {1999, -1, -2, 7}, {1999, 0, -3, 7}// 4	5	6	
			, {1998, 0, 1, 7}, {1998, -1, -4, 7}, {1997, -1, 3, 7}// 7	8	9	
			, {1997, -1, 1, 7}, {1997, -1, -1, 7}, {1997, -1, 0, 7}// 10	11	12	
			, {1997, -1, -3, 7}, {1997, 0, -4, 7}, {1997, 0, -2, 7}// 13	14	15	
			, {1997, 0, 0, 7}, {1997, 0, 2, 7}, {1997, 0, 3, 7}// 16	17	18	
			, {1998, 0, -1, 7}, {1998, 1, 3, 7}, {1997, 1, -4, 7}// 19	20	21	
			, {1997, 1, -3, 7}, {1997, 1, -2, 7}, {1997, 1, -1, 7}// 22	23	24	
			, {1998, 1, 0, 7}, {1997, 1, 1, 7}, {1999, 1, 2, 7}// 25	26	27	
			, {1997, 2, 2, 7}, {1997, 2, 1, 7}, {1999, 2, 0, 7}// 28	29	30	
			, {1997, 2, -1, 7}, {1997, 2, -2, 7}, {1998, 2, -3, 7}// 31	32	33	
			, {1997, 2, -4, 7}// 34	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GypsyWagonFloorSouth_AddonDeed();
			}
		}

		[ Constructable ]
		public GypsyWagonFloorSouth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5717, 2, -3, 0, 0, -1, "wheel", 1);// 35
			AddComplexComponent( (BaseAddon) this, 5717, 2, -2, 0, 0, -1, "wheel", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5717, 2, 1, 0, 0, -1, "wheel", 1);// 37
			AddComplexComponent( (BaseAddon) this, 5717, 2, 2, 0, 0, -1, "wheel", 1);// 38

		}

		public GypsyWagonFloorSouth_Addon( Serial serial ) : base( serial )
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

	public class GypsyWagonFloorSouth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GypsyWagonFloorSouth_Addon();
			}
		}

		[Constructable]
		public GypsyWagonFloorSouth_AddonDeed()
		{
			Name = "GypsyWagonFloorSouth_";
		}

		public GypsyWagonFloorSouth_AddonDeed( Serial serial ) : base( serial )
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