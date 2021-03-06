
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
	public class OvenLargeNewS_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5353, 2, 1, 7}, {5354, -2, 2, 7}, {7807, 2, 1, 0}// 1	2	3	
			, {7807, -2, 2, 0}, {2252, -2, 0, 10}, {83, 0, 0, 20}// 4	8	9	
			, {52, 1, -1, 0}, {52, 0, -1, 0}, {52, -1, -1, 0}// 10	11	12	
			, {54, -2, -1, 0}, {53, 1, 0, 0}, {53, -2, 0, 0}// 13	14	15	
			, {83, 1, 0, 20}, {83, -1, 0, 20}, {84, 1, 0, 20}// 16	17	18	
			, {84, -2, 0, 20}, {71, -1, 0, 0}, {72, 1, 0, 0}// 19	20	21	
			, {68, 0, 0, 4}, {68, -2, 0, 4}, {68, 0, 0, 5}// 29	30	31	
			, {53, -2, 0, 0}, {53, 1, 0, 0}// 48	49	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OvenLargeNewS_AddonDeed();
			}
		}

		[ Constructable ]
		public OvenLargeNewS_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1307, 1, 0, 20, 1891, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1307, 0, 0, 20, 1891, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1307, -1, 0, 20, 1891, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6571, 0, 0, 5, 0, 1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 6571, -1, 0, 5, 0, 1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 9, 1891, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 7386, -1, 0, 9, 1891, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 7386, -1, 0, 9, 1891, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 9, 1891, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2254, -1, 0, 8, 1891, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2253, 0, 0, 8, 1891, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1305, 2, 0, 0, 1891, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1305, 2, 1, 0, 1891, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1305, 2, 2, 0, 1891, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1305, 1, 2, 0, 1891, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1305, 0, 2, 0, 1891, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1305, -1, 2, 0, 1891, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1305, -2, 2, 0, 1891, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1305, -2, 1, 0, 1891, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1305, -2, 0, 0, 1891, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1801, 1, 0, 0, 1102, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 0, 1102, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 0, 1102, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1801, 1, 1, 0, 1102, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1801, 0, 1, 0, 1102, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 0, 1102, -1, "", 1);// 47

		}

		public OvenLargeNewS_Addon( Serial serial ) : base( serial )
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

	public class OvenLargeNewS_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OvenLargeNewS_Addon();
			}
		}

		[Constructable]
		public OvenLargeNewS_AddonDeed()
		{
			Name = "OvenLargeNewS_";
		}

		public OvenLargeNewS_AddonDeed( Serial serial ) : base( serial )
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