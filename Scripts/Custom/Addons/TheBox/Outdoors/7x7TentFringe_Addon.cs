
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
	public class TentFringe_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {888, -4, 5, 0}, {888, -3, 5, 0}, {888, -2, 5, 0}// 1	2	3	
			, {889, 5, -2, 0}, {889, 5, -3, 0}, {889, 5, -4, 0}// 4	5	6	
			, {889, 5, 3, 0}, {888, -1, 5, 0}, {888, 0, 5, 0}// 7	8	9	
			, {888, 1, 5, 0}, {888, 2, 5, 0}, {888, 3, 5, 0}// 10	11	12	
			, {889, 5, -1, 0}, {889, 5, 0, 0}, {889, 5, 1, 0}// 13	14	15	
			, {889, 5, 2, 0}// 16	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TentFringe_AddonDeed();
			}
		}

		[ Constructable ]
		public TentFringe_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public TentFringe_Addon( Serial serial ) : base( serial )
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

	public class TentFringe_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TentFringe_Addon();
			}
		}

		[Constructable]
		public TentFringe_AddonDeed()
		{
			Name = "7x7TentFringe_";
		}

		public TentFringe_AddonDeed( Serial serial ) : base( serial )
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