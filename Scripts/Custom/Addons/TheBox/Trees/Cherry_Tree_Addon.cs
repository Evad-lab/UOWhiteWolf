
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
	public class Cherry_Tree_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3207, 1, -1, 10}, {3207, 0, 1, 13}, {3207, -1, 2, 8}// 1	2	3	
			, {3207, 0, 2, 21}, {3207, 0, 2, 27}, {3207, 0, 2, 30}// 4	5	6	
			, {3207, 1, 0, 10}, {3207, 1, 0, 16}, {3207, 1, 0, 23}// 7	8	9	
			, {3207, 1, -1, 16}, {3293, 0, 0, 0}// 10	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Cherry_Tree_AddonDeed();
			}
		}

		[ Constructable ]
		public Cherry_Tree_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Cherry_Tree_Addon( Serial serial ) : base( serial )
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

	public class Cherry_Tree_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Cherry_Tree_Addon();
			}
		}

		[Constructable]
		public Cherry_Tree_AddonDeed()
		{
			Name = "Cherry_Tree_";
		}

		public Cherry_Tree_AddonDeed( Serial serial ) : base( serial )
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