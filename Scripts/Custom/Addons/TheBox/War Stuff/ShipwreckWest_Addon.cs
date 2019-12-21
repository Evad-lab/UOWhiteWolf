
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
	public class ShipwreckWest_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {18694, 2, 2, 0}, {18687, 3, 1, 0}, {18702, 0, 3, 0}// 1	2	3	
			, {18697, -1, 3, 0}, {18696, -2, 3, 0}, {18684, -1, 1, 0}// 4	5	6	
			, {18691, -1, 2, 0}, {18686, 2, 1, 0}, {18693, 1, 2, 0}// 7	8	9	
			, {18596, 1, 1, 0}, {18692, 0, 2, 0}, {18685, 0, 1, 0}// 10	11	12	
			, {18682, 3, 0, 0}, {18671, 0, -1, 0}, {18681, 2, 0, 0}// 13	14	15	
			, {18672, 1, -1, 0}, {18681, 1, 0, 0}, {18599, 0, -2, 0}// 16	17	18	
			, {18680, 1, 0, 0}, {18677, 0, 0, 0}// 19	20	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ShipwreckWest_AddonDeed();
			}
		}

		[ Constructable ]
		public ShipwreckWest_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public ShipwreckWest_Addon( Serial serial ) : base( serial )
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

	public class ShipwreckWest_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ShipwreckWest_Addon();
			}
		}

		[Constructable]
		public ShipwreckWest_AddonDeed()
		{
			Name = "ShipwreckWest_";
		}

		public ShipwreckWest_AddonDeed( Serial serial ) : base( serial )
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