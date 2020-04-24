
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CustomChoppingBlockAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4654, 2, 0, 2}, {4722, -1, 0, 0}, {4723, -1, -1, 0}// 1	2	3	
			, {4719, 0, 0, 0}, {4718, 0, -1, 0}, {4728, 1, 0, 0}// 4	5	6	
			, {4717, 1, -1, 0}, {7390, 0, 0, 2}, {7396, 1, 0, 2}// 7	8	9	
			, {4717, 2, -1, 0}, {6933, 2, 0, 2}, {4716, 2, 0, 0}// 10	11	12	
			, {4720, 1, 1, 0}, {4715, 2, 1, 0}, {4721, -1, 1, 0}// 13	14	15	
			, {4533, 1, 1, 2}, {4651, 2, 1, 2}, {4720, 0, 1, 0}// 16	17	18	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CustomChoppingBlockAddonDeed();
			}
		}

		[ Constructable ]
		public CustomChoppingBlockAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CustomChoppingBlockAddon( Serial serial ) : base( serial )
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

	public class CustomChoppingBlockAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CustomChoppingBlockAddon();
			}
		}

		[Constructable]
		public CustomChoppingBlockAddonDeed()
		{
			Name = "CustomChoppingBlock";
		}

		public CustomChoppingBlockAddonDeed( Serial serial ) : base( serial )
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