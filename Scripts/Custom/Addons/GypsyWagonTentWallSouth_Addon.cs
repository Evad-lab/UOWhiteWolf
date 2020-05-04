
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
	public class GypsyWagonTentWallSouth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {743, -1, 4, 1}, {743, 2, 4, 1}, {742, 2, 4, 1}// 1	2	3	
			, {742, 2, 3, 1}, {742, 2, 2, 1}, {742, 2, 1, 1}// 4	5	6	
			, {742, 2, 0, 1}, {742, 2, -1, 1}, {742, 2, -2, 1}// 7	8	9	
			, {742, 2, -3, 0}, {742, -2, 4, 1}, {742, -2, 3, 1}// 10	11	12	
			, {742, -2, 2, 1}, {742, -2, 1, 1}, {742, -2, 0, 1}// 13	14	15	
			, {742, -2, -1, 1}, {742, -2, -2, 1}, {742, -2, -3, 1}// 16	17	18	
			, {743, 2, -4, 1}, {743, 1, -4, 1}, {743, 0, -4, 1}// 19	20	21	
			, {743, -1, -4, 1}// 22	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GypsyWagonTentWallSouth_AddonDeed();
			}
		}

		[ Constructable ]
		public GypsyWagonTentWallSouth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GypsyWagonTentWallSouth_Addon( Serial serial ) : base( serial )
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

	public class GypsyWagonTentWallSouth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GypsyWagonTentWallSouth_Addon();
			}
		}

		[Constructable]
		public GypsyWagonTentWallSouth_AddonDeed()
		{
			Name = "GypsyWagonTentWallSouth_";
		}

		public GypsyWagonTentWallSouth_AddonDeed( Serial serial ) : base( serial )
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