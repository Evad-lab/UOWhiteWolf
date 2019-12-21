
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
	public class PoinsettiaBenchEast_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3167, 0, 1, 25}, {3167, 0, 0, 24}// 8	9	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PoinsettiaBenchEast_AddonDeed();
			}
		}

		[ Constructable ]
		public PoinsettiaBenchEast_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 41259, 0, -1, 0, 33, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 41248, 1, 2, 5, 33, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 41259, 0, 2, 5, 33, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 41188, 0, 0, 25, 33, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 41188, 0, 1, 26, 33, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 41248, 0, -1, 7, 33, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 41248, 0, -1, 0, 33, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 41248, 1, 2, 14, 33, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 41259, 1, 2, 4, 33, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 41248, 0, 2, 13, 33, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 41248, 0, 2, 0, 33, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1114, 0, 1, 0, 1153, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1114, 0, 0, 0, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10722, 0, -1, 20, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10721, 0, 0, 20, 1153, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10722, 0, 0, 20, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 10721, 0, 1, 20, 1153, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2186, 0, -1, 10, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2186, 0, -1, 0, 1153, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2186, 0, 1, 10, 1153, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2186, 0, 1, 0, 1153, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 10724, -1, -1, 20, 1153, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10723, -1, 0, 20, 1153, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10723, -1, 1, 20, 1153, -1, "", 1);// 26

		}

		public PoinsettiaBenchEast_Addon( Serial serial ) : base( serial )
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

	public class PoinsettiaBenchEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PoinsettiaBenchEast_Addon();
			}
		}

		[Constructable]
		public PoinsettiaBenchEast_AddonDeed()
		{
			Name = "PoinsettiaBenchEast_";
		}

		public PoinsettiaBenchEast_AddonDeed( Serial serial ) : base( serial )
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