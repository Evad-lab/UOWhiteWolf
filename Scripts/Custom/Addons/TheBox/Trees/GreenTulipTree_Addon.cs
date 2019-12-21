
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
	public class GreenTulipTree_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3283, 0, 0, 0}// 8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GreenTulipTree_AddonDeed();
			}
		}

		[ Constructable ]
		public GreenTulipTree_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 41249, 0, 1, 12, 67, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41249, 0, 1, 17, 67, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41249, 0, 1, 27, 67, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41249, 1, 0, 20, 67, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41249, 1, 0, 28, 67, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41249, 1, 0, 13, 67, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 41249, 1, 1, 41, 67, -1, "", 1);// 7

		}

		public GreenTulipTree_Addon( Serial serial ) : base( serial )
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

	public class GreenTulipTree_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GreenTulipTree_Addon();
			}
		}

		[Constructable]
		public GreenTulipTree_AddonDeed()
		{
			Name = "GreenTulipTree_";
		}

		public GreenTulipTree_AddonDeed( Serial serial ) : base( serial )
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