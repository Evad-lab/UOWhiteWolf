
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
	public class Halloween_DiningAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2731, 2, 2, 0}, {2731, 1, 2, 0}, {2731, 0, 2, 0}// 1	2	3	
			, {2731, -1, 2, 0}, {2731, -2, 2, 0}, {3117, -2, 2, 0}// 4	5	6	
			, {3098, 0, 2, 0}, {4310, 1, 2, 0}, {2495, 0, 1, 8}// 7	8	9	
			, {2495, 0, 0, 8}, {2495, 1, 0, 6}, {2495, 1, 1, 6}// 10	11	12	
			, {2517, 1, 1, 7}, {2517, 1, 0, 6}, {3099, 0, -2, 0}// 13	14	15	
			, {2466, 0, 0, 6}, {2731, 2, 1, 0}, {2731, 2, 0, 0}// 16	17	18	
			, {2731, 2, -1, 0}, {2731, 2, -2, 0}, {2731, 1, 1, 0}// 19	20	21	
			, {2731, 1, 0, 0}, {2731, 1, -1, 0}, {2731, 1, -2, 0}// 22	23	24	
			, {2731, 0, 1, 0}, {2731, 0, 0, 0}, {2731, 0, -1, 0}// 25	26	27	
			, {2731, 0, -2, 0}, {2731, -1, 1, 0}, {2731, -1, 0, 0}// 28	29	30	
			, {2731, -1, -1, 0}, {2731, -1, -2, 0}, {2731, -2, 1, 0}// 31	32	33	
			, {2731, -2, 0, 0}, {2731, -2, -1, 0}, {2731, -2, -2, 0}// 34	35	36	
			, {3792, 2, 1, 0}, {2519, 1, 1, 6}, {2519, 1, 0, 6}// 37	40	41	
			, {2519, 1, -1, 6}, {2519, -1, 1, 6}, {2519, -1, 0, 6}// 42	43	44	
			, {2519, -1, -1, 6}, {3787, -2, -2, 0}, {3100, -2, -1, 0}// 45	46	47	
			, {3096, -2, 1, 0}, {2931, -1, 0, 0}, {2931, -1, -1, 0}// 48	49	50	
			, {2931, 0, -1, 0}, {2931, 0, 0, 0}, {2930, 1, -1, 0}// 51	52	53	
			, {2928, -1, 1, 0}, {2931, 1, 0, 0}, {2932, 0, 1, 0}// 54	55	56	
			, {2929, 1, 1, 0}, {3101, 2, 0, 0}, {3101, 2, -1, 0}// 57	58	59	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Halloween_DiningAddonDeed();
			}
		}

		[ Constructable ]
		public Halloween_DiningAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2842, 0, 1, 6, 0, 0, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2842, 0, -1, 6, 0, 0, "", 1);// 39

		}

		public Halloween_DiningAddon( Serial serial ) : base( serial )
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

	public class Halloween_DiningAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Halloween_DiningAddon();
			}
		}

		[Constructable]
		public Halloween_DiningAddonDeed()
		{
			Name = "Halloween_Dining";
		}

		public Halloween_DiningAddonDeed( Serial serial ) : base( serial )
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