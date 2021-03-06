
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
	public class ThornFlower4Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {41375, 0, 0, 17}, {17074, 0, 0, 9}, {17090, 0, 0, 0}// 6	7	8	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ThornFlower4AddonDeed();
			}
		}

		[ Constructable ]
		public ThornFlower4Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 41257, 1, 0, 25, 91, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41257, 1, 1, 26, 91, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41257, 0, 1, 24, 91, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6093, 0, 0, 18, 0, -1, "flowers", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41187, 0, 0, 18, 53, -1, "", 1);// 5

		}

		public ThornFlower4Addon( Serial serial ) : base( serial )
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

	public class ThornFlower4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ThornFlower4Addon();
			}
		}

		[Constructable]
		public ThornFlower4AddonDeed()
		{
			Name = "ThornFlower4";
		}

		public ThornFlower4AddonDeed( Serial serial ) : base( serial )
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