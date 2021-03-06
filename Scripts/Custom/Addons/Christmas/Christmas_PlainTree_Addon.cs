
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
	public class Christmas_PlainTree_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3879, 1, 0, 33}, {3878, 1, 0, 28}, {3860, 1, 0, 27}// 1	2	3	
			, {3868, 1, 0, 25}, {3856, 1, 0, 24}, {3883, 0, 1, 48}// 4	5	6	
			, {3866, 0, 1, 40}, {3880, 0, 1, 36}, {3861, 0, 1, 30}// 7	8	9	
			, {3858, 0, 1, 29}, {3859, 0, 1, 24}, {3855, 0, 1, 23}// 10	11	12	
			, {3870, 0, 1, 18}, {3862, 0, 1, 18}, {3881, 0, 0, 45}// 13	14	15	
			, {3888, 0, 0, 44}, {3882, 0, 0, 43}, {3875, 0, 0, 41}// 16	17	18	
			, {3887, 0, 0, 39}, {3867, 0, 0, 32}, {3865, 0, 0, 31}// 19	20	21	
			, {3871, 0, 0, 31}, {3876, 0, 0, 31}, {3863, 0, 0, 30}// 22	23	24	
			, {3872, 0, 0, 26}, {3864, 0, 0, 20}, {3874, 0, 0, 13}// 25	26	27	
			, {3286, -1, -1, 0}, {3287, -1, -1, 0}// 28	29	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Christmas_PlainTree_AddonDeed();
			}
		}

		[ Constructable ]
		public Christmas_PlainTree_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Christmas_PlainTree_Addon( Serial serial ) : base( serial )
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

	public class Christmas_PlainTree_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Christmas_PlainTree_Addon();
			}
		}

		[Constructable]
		public Christmas_PlainTree_AddonDeed()
		{
			Name = "Christmas_PlainTree_";
		}

		public Christmas_PlainTree_AddonDeed( Serial serial ) : base( serial )
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