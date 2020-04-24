
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
	public class CatapultEast_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5773, 2, 1, 0}, {5768, 2, -1, 0}, {5763, 0, -1, 0}// 1	2	3	
			, {5758, 0, 1, 0}, {5748, 1, -1, 0}, {5753, 2, 1, 0}// 4	5	6	
			, {5752, 0, 0, 0}, {5751, -1, 1, 0}, {5750, -1, 0, 0}// 7	8	9	
			, {5749, -1, -1, 0}, {5747, 1, 1, 0}, {5746, 2, 0, 0}// 10	11	12	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CatapultEast_AddonDeed();
			}
		}

		[ Constructable ]
		public CatapultEast_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CatapultEast_Addon( Serial serial ) : base( serial )
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

	public class CatapultEast_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CatapultEast_Addon();
			}
		}

		[Constructable]
		public CatapultEast_AddonDeed()
		{
			Name = "CatapultEast_";
		}

		public CatapultEast_AddonDeed( Serial serial ) : base( serial )
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