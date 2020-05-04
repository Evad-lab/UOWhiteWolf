
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
	public class TentWallsSouth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {498, 4, 1, 0}, {498, 4, 0, 0}, {498, 4, -1, 0}// 1	2	3	
			, {739, 4, -4, 0}, {497, 3, 4, 0}, {498, 4, 2, 0}// 4	5	6	
			, {498, 4, 3, 0}, {498, 4, -2, 0}, {498, 4, -3, 0}// 7	8	9	
			, {496, 4, 4, 0}, {502, 3, -4, 0}, {503, -4, -3, 0}// 10	11	12	
			, {497, 2, 4, 0}, {497, -2, 4, 0}, {497, -3, 4, 0}// 13	14	15	
			, {502, -1, -4, 0}, {502, 2, -4, 0}, {502, 1, -4, 0}// 16	17	18	
			, {502, 0, -4, 0}, {502, -2, -4, 0}, {502, -3, -4, 0}// 19	20	21	
			, {503, -4, -1, 0}, {503, -4, -2, 0}, {503, -4, 1, 0}// 22	23	24	
			, {503, -4, 0, 0}, {503, -4, 3, 0}, {503, -4, 2, 0}// 25	26	27	
			, {500, -4, 4, 0}// 28	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TentWallsSouth_AddonDeed();
			}
		}

		[ Constructable ]
		public TentWallsSouth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public TentWallsSouth_Addon( Serial serial ) : base( serial )
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

	public class TentWallsSouth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TentWallsSouth_Addon();
			}
		}

		[Constructable]
		public TentWallsSouth_AddonDeed()
		{
			Name = "7x7TentWallsSouth_";
		}

		public TentWallsSouth_AddonDeed( Serial serial ) : base( serial )
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