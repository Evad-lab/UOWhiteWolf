
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
	public class Small_DiningSetAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {11756, 0, -1, 0}, {11755, 0, 2, 0}, {2519, 0, 0, 6}// 2	3	6	
			, {2519, 0, 1, 5}// 7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Small_DiningSetAddonDeed();
			}
		}

		[ Constructable ]
		public Small_DiningSetAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2458, 0, 1, 10, 2721, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2516, 0, 1, 6, 2721, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2494, 0, 0, 6, 2721, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4609, 0, 1, 0, 1022, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4610, 0, 0, 0, 1022, -1, "", 1);// 9

		}

		public Small_DiningSetAddon( Serial serial ) : base( serial )
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

	public class Small_DiningSetAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Small_DiningSetAddon();
			}
		}

		[Constructable]
		public Small_DiningSetAddonDeed()
		{
			Name = "Small_DiningSet";
		}

		public Small_DiningSetAddonDeed( Serial serial ) : base( serial )
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