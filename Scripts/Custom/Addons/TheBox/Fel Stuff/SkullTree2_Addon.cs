
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
	public class SkullTree2_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7574, 1, -1, 8}, {3277, 0, -1, 0}, {6884, 2, -1, 30}// 1	2	3	
			, {6881, -1, 0, 12}, {6881, -1, 0, 20}, {6883, 1, -1, 18}// 4	5	6	
			, {7573, -1, 0, 0}, {6880, 1, 1, 44}, {6884, 1, -1, 21}// 7	8	9	
			, {7570, 1, 1, 22}, {6884, 2, 0, 46}, {6880, 1, 1, 29}// 10	11	12	
			, {6883, 1, 1, 38}, {6881, 1, 0, 21}, {6883, 1, 0, 35}// 13	14	15	
			, {6882, 1, 0, 42}, {6881, 1, 0, 27}, {6880, 1, 1, 35}// 16	17	18	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SkullTree2_AddonDeed();
			}
		}

		[ Constructable ]
		public SkullTree2_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SkullTree2_Addon( Serial serial ) : base( serial )
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

	public class SkullTree2_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SkullTree2_Addon();
			}
		}

		[Constructable]
		public SkullTree2_AddonDeed()
		{
			Name = "SkullTree2_";
		}

		public SkullTree2_AddonDeed( Serial serial ) : base( serial )
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