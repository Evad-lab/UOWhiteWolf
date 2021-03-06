
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
	public class DdWHeartpond8x8Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6039, -1, 1, 0}, {6039, -1, 2, 0}, {6039, -1, 3, 0}// 1	2	3	
			, {6039, -2, 2, 0}, {6059, -2, 3, 0}, {6048, -1, 0, 0}// 4	5	6	
			, {6054, -3, 0, 0}, {6056, -2, 4, 0}, {6051, -3, 2, 0}// 7	8	9	
			, {6056, -3, 3, 0}, {6039, -2, 1, 0}, {6047, -2, 0, 0}// 10	11	12	
			, {6051, -3, 1, 0}, {6050, -1, 4, 0}, {6039, 1, 1, 0}// 13	14	15	
			, {6039, 2, -1, 0}, {6039, 3, -1, 0}, {6039, 1, -2, 0}// 16	17	18	
			, {6039, 0, 1, 0}, {6039, 3, 0, 0}, {6039, 3, 1, 0}// 19	20	21	
			, {6039, 3, 2, 0}, {6039, 3, 3, 0}, {6039, 0, 3, 0}// 22	23	24	
			, {6039, 1, 3, 0}, {6039, 2, 3, 0}, {6039, 0, 2, 0}// 25	26	27	
			, {6039, 1, 2, 0}, {6039, 2, 2, 0}, {6039, 2, 0, 0}// 28	29	30	
			, {6039, 2, 1, 0}, {6047, 2, -3, 0}, {6057, 3, -2, 0}// 31	32	33	
			, {6039, 2, -2, 0}, {6053, 3, -3, 0}, {6053, 4, -2, 0}// 34	35	36	
			, {6046, 4, -1, 0}, {6046, 4, 0, 0}, {6046, 4, 1, 0}// 37	38	39	
			, {6046, 4, 2, 0}, {6046, 4, 3, 0}, {6052, 0, -1, 0}// 40	41	42	
			, {6050, 0, 4, 0}, {6050, 1, 4, 0}, {6050, 2, 4, 0}// 43	44	45	
			, {6050, 3, 4, 0}, {6054, 0, -2, 0}, {6054, 0, -3, 0}// 46	47	48	
			, {6055, 4, 4, 0}, {6051, 0, -2, 0}, {6048, 0, 0, 0}// 49	50	51	
			, {6047, 1, -3, 0}, {6039, 1, -1, 0}, {6039, 1, 0, 0}// 52	53	54	
			, {6052, 0, 0, 0}// 55	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DdWHeartpond8x8AddonDeed();
			}
		}

		[ Constructable ]
		public DdWHeartpond8x8Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DdWHeartpond8x8Addon( Serial serial ) : base( serial )
		{
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

	public class DdWHeartpond8x8AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DdWHeartpond8x8Addon();
			}
		}

		[Constructable]
		public DdWHeartpond8x8AddonDeed()
		{
			Name = "DdWHeartpond8x8";
		}

		public DdWHeartpond8x8AddonDeed( Serial serial ) : base( serial )
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