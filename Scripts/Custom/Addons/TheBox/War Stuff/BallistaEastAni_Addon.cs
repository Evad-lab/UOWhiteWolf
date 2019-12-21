
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
	public class BallistaEastAni_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {16223, 0, -2, 0}, {16215, 0, 2, 0}, {16217, 0, 1, 0}// 1	2	3	
			, {16221, 0, -1, 0}, {16219, 0, 0, 0}, {16209, -1, 1, 0}// 4	5	6	
			, {16213, -1, -1, 0}, {16211, -1, 0, 0}, {16228, 2, 0, 0}// 7	8	9	
			, {16227, 1, -1, 0}, {16226, 1, 0, 0}, {16225, 1, 1, 0}// 10	11	12	
			, {16208, -2, 0, 0}, {16196, 2, -1, 0}, {16191, 2, 1, 0}// 13	14	15	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BallistaEastAni_AddonDeed();
			}
		}

		[ Constructable ]
		public BallistaEastAni_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BallistaEastAni_Addon( Serial serial ) : base( serial )
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

	public class BallistaEastAni_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BallistaEastAni_Addon();
			}
		}

		[Constructable]
		public BallistaEastAni_AddonDeed()
		{
			Name = "BallistaEastAni_";
		}

		public BallistaEastAni_AddonDeed( Serial serial ) : base( serial )
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