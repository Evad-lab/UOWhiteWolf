
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
	public class Thanksgiving_DiningAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2517, 1, -1, 7}, {2479, 0, 2, 6}, {2479, -1, 1, 6}// 16	32	33	
			, {2479, -1, 0, 6}, {2479, -1, -1, 6}, {2479, 1, 1, 6}// 34	35	36	
			, {2479, 1, -1, 6}, {2479, 1, 0, 5}, {2479, 0, -2, 6}// 37	47	50	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Thanksgiving_DiningAddonDeed();
			}
		}

		[ Constructable ]
		public Thanksgiving_DiningAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2897, 2, -1, 0, 137, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2894, -2, 0, 0, 137, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2896, 0, 3, 0, 137, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2894, -2, 1, 0, 137, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2894, -2, -1, 0, 137, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2897, 2, 1, 0, 137, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2897, 2, 0, 0, 137, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 10299, 0, -1, 10, 1920, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 10299, 0, -1, 5, 1920, -1, "poinsettia", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3232, 0, -1, 5, 0, -1, "poinsettia", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2493, -1, 1, 7, 2721, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2493, -1, 0, 7, 2721, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2493, -1, -1, 7, 2721, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2517, 1, 1, 7, 2721, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2517, 1, 0, 6, 2721, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2516, 0, 2, 7, 2721, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10299, 1, 2, 20, 1920, -1, "poinsettia", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3232, 0, 1, 5, 0, -1, "poinsettia", 1);// 19
			AddComplexComponent( (BaseAddon) this, 10299, 1, 2, 16, 1920, -1, "poinsettia", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2458, 0, 1, 13, 2721, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2458, 0, -1, 12, 2721, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2458, 1, 3, 21, 2721, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2458, 1, -1, 10, 2721, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2458, 1, 0, 10, 2721, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2458, 1, 1, 11, 2721, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2458, 0, 2, 14, 2721, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2458, 0, 0, 13, 2721, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 4612, 1, 2, 0, 1007, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 4614, 0, 2, 0, 1007, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 4613, -1, 2, 0, 1007, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 4612, 1, -1, 0, 1007, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 4613, -1, -1, 0, 1007, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 4614, 0, -1, 0, 1007, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 4612, 1, 1, 0, 1007, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 4614, 0, 1, 0, 1007, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 4613, -1, 1, 0, 1007, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 4612, 1, 0, 0, 1007, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4614, 0, 0, 0, 1007, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 4613, -1, 0, 0, 1007, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2895, 0, -3, 0, 137, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2494, 0, -2, 7, 2721, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 4612, 1, -2, 0, 1007, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 4614, 0, -2, 0, 1007, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 4613, -1, -2, 0, 1007, -1, "", 1);// 53

		}

		public Thanksgiving_DiningAddon( Serial serial ) : base( serial )
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

	public class Thanksgiving_DiningAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Thanksgiving_DiningAddon();
			}
		}

		[Constructable]
		public Thanksgiving_DiningAddonDeed()
		{
			Name = "Thanksgiving_Dining";
		}

		public Thanksgiving_DiningAddonDeed( Serial serial ) : base( serial )
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