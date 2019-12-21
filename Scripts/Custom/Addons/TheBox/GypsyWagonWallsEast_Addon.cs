
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
	public class GypsyWagonWallsEast_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {569, 4, 2, 0}, {563, -4, 2, 16}, {563, 4, 2, 15}// 1	2	3	
			, {563, 4, -2, 15}, {563, -3, -1, 24}, {2102, 4, 2, 8}// 4	5	6	
			, {2103, 4, 2, 8}, {2102, 4, -2, 8}, {2102, 3, -2, 8}// 7	8	9	
			, {2102, 0, 2, 8}, {2102, 1, 2, 8}, {2102, 2, 2, 8}// 10	11	12	
			, {2102, 3, 2, 8}, {2102, -1, 2, 8}, {2102, -2, 2, 8}// 13	14	15	
			, {2102, -3, 2, 8}, {2102, 2, -2, 8}, {2102, 1, -2, 8}// 16	17	18	
			, {2102, 0, -2, 8}, {2102, -1, -2, 8}, {2102, -2, -2, 8}// 19	20	21	
			, {2102, -3, -2, 8}, {2103, -4, 2, 8}, {2103, -4, 1, 8}// 22	23	24	
			, {2103, -4, 0, 8}, {2103, -4, -1, 8}, {2103, 4, -1, 8}// 25	26	27	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GypsyWagonWallsEast_AddonDeed();
			}
		}

		[ Constructable ]
		public GypsyWagonWallsEast_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GypsyWagonWallsEast_Addon( Serial serial ) : base( serial )
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

	public class GypsyWagonWallsEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GypsyWagonWallsEast_Addon();
			}
		}

		[Constructable]
		public GypsyWagonWallsEast_AddonDeed()
		{
			Name = "GypsyWagonWallsEast_";
		}

		public GypsyWagonWallsEast_AddonDeed( Serial serial ) : base( serial )
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