
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
	public class PotBellyStoveSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2416, 0, 0, 17}, {2541, 0, 0, 12}, {3136, 0, 0, 11}// 1	2	5	
			, {3133, 1, 0, 11}, {2516, 1, 0, 8}, {2495, 1, 0, 8}// 6	7	8	
			, {2522, 1, 0, 7}, {2908, 1, 1, 1}, {7137, 0, 0, 2}// 9	10	11	
			, {7134, 1, 0, 0}, {2879, 1, 0, 1}// 13	14	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PotBellyStoveSouthAddonDeed();
			}
		}

		[ Constructable ]
		public PotBellyStoveSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 67, 0, 0, 7, 1899, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 63, 0, 0, 1, 1899, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6571, 0, 0, 7, 0, 0, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1180, 0, 0, 3, 1899, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1180, 0, 0, 12, 1899, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 78, 0, 0, 1, 1899, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 441, -1, -1, 1, 1899, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 63, -1, 0, 1, 1899, -1, "", 1);// 19

		}

		public PotBellyStoveSouthAddon( Serial serial ) : base( serial )
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

	public class PotBellyStoveSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PotBellyStoveSouthAddon();
			}
		}

		[Constructable]
		public PotBellyStoveSouthAddonDeed()
		{
			Name = "PotBellyStoveSouth";
		}

		public PotBellyStoveSouthAddonDeed( Serial serial ) : base( serial )
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