
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
	public class trellisBenchSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3203, 2, 0, 1}, {3203, 1, 0, 1}, {3203, 0, 0, 1}// 7	8	9	
			, {11514, 0, 0, 6}, {9036, 2, 0, 22}, {9036, 0, 0, 22}// 10	14	15	
			, {3167, 1, 0, 22}, {3208, 1, 0, 23}// 16	17	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new trellisBenchSAddonDeed();
			}
		}

		[ Constructable ]
		public trellisBenchSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2187, 2, 0, 2, 1153, -1, "trellis", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2187, -1, 0, 1, 1153, -1, "trellis", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2187, -1, 0, 11, 1153, -1, "trellis", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2187, 2, 0, 11, 1153, -1, "trellis", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1113, 0, 0, 0, 1150, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1113, 1, 0, 0, 1150, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7387, 2, 0, 22, 1153, -1, "screen", 1);// 11
			AddComplexComponent( (BaseAddon) this, 7387, 1, 0, 22, 1153, -1, "screen", 1);// 12
			AddComplexComponent( (BaseAddon) this, 7387, 0, 0, 22, 1153, -1, "screen", 1);// 13

		}

		public trellisBenchSAddon( Serial serial ) : base( serial )
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

	public class trellisBenchSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new trellisBenchSAddon();
			}
		}

		[Constructable]
		public trellisBenchSAddonDeed()
		{
			Name = "trellisBenchS";
		}

		public trellisBenchSAddonDeed( Serial serial ) : base( serial )
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