
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
	public class conversationPitEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -1, -3, 0}, {1848, -2, -3, 0}, {1848, -1, -2, 1}// 1	2	3	
			, {1848, -1, 2, 0}, {2758, -1, -2, 0}, {2758, -1, -1, 0}// 4	5	6	
			, {2758, -1, 0, 0}, {2758, -1, 1, 0}, {2758, -1, 2, 0}// 7	8	9	
			, {1848, -1, 3, 0}, {1848, -2, -2, 0}, {1848, -2, 2, 0}// 10	14	15	
			, {1848, -2, 3, 0}, {1848, -2, 1, 0}, {1848, -2, 0, 0}// 16	17	18	
			, {1848, -2, -1, 0}, {1848, 3, -3, 0}, {1848, 2, -3, 0}// 19	22	23	
			, {1848, 1, -3, 0}, {1848, 0, -3, 0}, {1848, 3, 2, 0}// 24	25	27	
			, {2758, 0, -2, 0}, {2758, 0, -1, 0}, {2758, 0, 0, 0}// 28	29	30	
			, {2758, 0, 1, 0}, {2758, 0, 2, 0}, {2758, 1, -2, 0}// 31	32	33	
			, {2758, 1, -1, 0}, {2758, 1, 0, 0}, {2758, 1, 1, 0}// 34	35	36	
			, {2758, 1, 2, 0}, {2758, 2, -2, 0}, {2758, 2, -1, 0}// 37	38	39	
			, {2758, 2, 0, 0}, {2758, 2, 1, 0}, {2758, 2, 2, 0}// 40	41	42	
			, {1848, 3, -2, 0}, {2758, 3, -1, 0}, {2758, 3, 0, 0}// 55	59	60	
			, {2758, 3, 1, 0}, {1848, 3, 3, 0}, {1848, 1, 3, 0}// 61	65	66	
			, {1848, 2, 3, 0}, {1848, 0, 3, 0}// 67	69	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new conversationPitEAddonDeed();
			}
		}

		[ Constructable ]
		public conversationPitEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4633, -1, -1, 0, 1031, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4633, -1, 0, 0, 1031, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4633, -1, 1, 0, 1031, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 11676, -1, -2, 13, 1150, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 5035, -2, 0, 5, 33, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 5032, 1, -3, 5, 33, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2723, 0, -1, 0, 0, -1, "table", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2724, 2, -1, 0, 0, -1, "table", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2725, 0, 1, 0, 0, -1, "table", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2840, 2, 1, 0, 0, -1, "table", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2720, 1, 1, 0, 0, -1, "table", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2719, 2, 0, 0, 0, -1, "table", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2721, 0, 0, 0, 0, -1, "table", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2722, 1, -1, 0, 0, -1, "table", 1);// 50
			AddComplexComponent( (BaseAddon) this, 7386, 2, 1, 8, 1150, -1, "frosted glass", 1);// 51
			AddComplexComponent( (BaseAddon) this, 7386, 1, 1, 8, 1150, -1, "frosted glass", 1);// 52
			AddComplexComponent( (BaseAddon) this, 7386, 1, 0, 8, 1150, -1, "frosted glass", 1);// 53
			AddComplexComponent( (BaseAddon) this, 7386, 2, 0, 8, 1150, -1, "frosted glass", 1);// 54
			AddComplexComponent( (BaseAddon) this, 4632, 0, -2, 0, 1031, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 4632, 1, -2, 0, 1031, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 4632, 2, -2, 0, 1031, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 4634, 2, 2, 0, 1031, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 4634, 1, 2, 0, 1031, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 4634, 0, 2, 0, 1031, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5036, 1, 3, 5, 33, -1, "", 1);// 68

		}

		public conversationPitEAddon( Serial serial ) : base( serial )
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

	public class conversationPitEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new conversationPitEAddon();
			}
		}

		[Constructable]
		public conversationPitEAddonDeed()
		{
			Name = "conversationPitE";
		}

		public conversationPitEAddonDeed( Serial serial ) : base( serial )
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