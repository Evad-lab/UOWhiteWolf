
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
	public class BallistaNorth_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5888, 2, 0, 0}, {5889, 1, -1, 0}, {5885, 1, 0, 0}// 1	2	3	
			, {5883, 1, 1, 0}, {5882, 0, -2, 0}, {5893, -1, -1, 0}// 4	5	6	
			, {5887, 0, 2, 0}, {5886, 0, 1, 0}, {5881, -2, 0, 0}// 7	8	9	
			, {5884, -1, 0, 0}, {5880, -1, 0, 0}// 10	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BallistaNorth_AddonDeed();
			}
		}

		[ Constructable ]
		public BallistaNorth_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BallistaNorth_Addon( Serial serial ) : base( serial )
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

	public class BallistaNorth_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BallistaNorth_Addon();
			}
		}

		[Constructable]
		public BallistaNorth_AddonDeed()
		{
			Name = "BallistaNorth_";
		}

		public BallistaNorth_AddonDeed( Serial serial ) : base( serial )
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