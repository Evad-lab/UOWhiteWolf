
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
	public class RevisedFirePlaceSouth2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4604, 0, 1, 4}, {2867, -1, 1, 4}, {7777, 0, 0, 7}// 1	2	3	
			, {486, 1, 0, 4}, {486, -2, 0, 4}, {7712, 0, 2, 3}// 4	5	6	
			, {1312, 1, 0, 4}, {1312, 2, 0, 4}, {1312, 0, 0, 4}// 7	8	9	
			, {1312, -1, 0, 4}, {1312, -2, 0, 4}, {466, -2, -2, 4}// 10	11	12	
			, {464, 0, -2, 4}, {464, -1, -2, 4}, {464, 1, -2, 4}// 13	14	15	
			, {487, 2, -1, 4}, {489, -1, -1, 21}, {489, 1, -1, 17}// 16	17	18	
			, {489, 1, -1, 21}, {489, 0, -1, 17}, {489, 0, -1, 21}// 19	20	21	
			, {470, -1, -1, 0}, {465, 1, -1, 4}, {465, -2, -1, 4}// 22	23	24	
			, {7138, 0, -1, 4}, {1312, 2, -1, 4}, {1312, 1, -1, 4}// 27	28	29	
			, {1312, 0, -1, 4}, {1312, -1, -1, 4}, {1312, -2, -1, 4}// 30	31	32	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RevisedFirePlaceSouth2AddonDeed();
			}
		}

		[ Constructable ]
		public RevisedFirePlaceSouth2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14742, 0, -1, 4, 0, 0, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 14732, 0, -1, 3, 0, 0, "", 1);// 26

		}

		public RevisedFirePlaceSouth2Addon( Serial serial ) : base( serial )
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

	public class RevisedFirePlaceSouth2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RevisedFirePlaceSouth2Addon();
			}
		}

		[Constructable]
		public RevisedFirePlaceSouth2AddonDeed()
		{
			Name = "RevisedFirePlaceSouth2";
		}

		public RevisedFirePlaceSouth2AddonDeed( Serial serial ) : base( serial )
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