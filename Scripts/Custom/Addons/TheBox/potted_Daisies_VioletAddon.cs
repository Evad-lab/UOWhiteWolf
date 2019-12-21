
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
	public class potted_Daisies_VioletAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4551, 0, 0, 0}// 8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new potted_Daisies_VioletAddonDeed();
			}
		}

		[ Constructable ]
		public potted_Daisies_VioletAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 15, 1195, -1, "Daisies", 2);// 1
			AddComplexComponent( (BaseAddon) this, 4179, 1, 0, 9, 1195, -1, "Daisies", 2);// 2
			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 12, 1195, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4179, 0, 0, 8, 1195, -1, "Daisies", 2);// 4
			AddComplexComponent( (BaseAddon) this, 4179, 0, 1, 10, 1195, -1, "Daisies", 2);// 5
			AddComplexComponent( (BaseAddon) this, 6093, 0, 0, 6, 0, -1, "Daisies", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3332, 0, 0, 3, 0, -1, "Daisies", 1);// 7

		}

		public potted_Daisies_VioletAddon( Serial serial ) : base( serial )
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

	public class potted_Daisies_VioletAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new potted_Daisies_VioletAddon();
			}
		}

		[Constructable]
		public potted_Daisies_VioletAddonDeed()
		{
			Name = "potted_Daisies_Violet";
		}

		public potted_Daisies_VioletAddonDeed( Serial serial ) : base( serial )
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