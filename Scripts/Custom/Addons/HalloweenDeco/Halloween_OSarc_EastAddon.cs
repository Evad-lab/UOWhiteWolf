
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
	public class Halloween_OSarc_EastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4310, 1, 1, 0}, {7467, -1, -1, 0}, {7466, -1, 0, 0}// 1	2	3	
			, {7469, 0, 0, 0}, {7303, 1, 0, 0}, {7302, 2, 0, 0}// 4	5	6	
			, {7311, 2, -1, 0}, {7310, 1, -1, 0}, {7309, 0, -1, 0}// 7	8	9	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Halloween_OSarc_EastAddonDeed();
			}
		}

		[ Constructable ]
		public Halloween_OSarc_EastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Halloween_OSarc_EastAddon( Serial serial ) : base( serial )
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

	public class Halloween_OSarc_EastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Halloween_OSarc_EastAddon();
			}
		}

		[Constructable]
		public Halloween_OSarc_EastAddonDeed()
		{
			Name = "Halloween_OSarc_East";
		}

		public Halloween_OSarc_EastAddonDeed( Serial serial ) : base( serial )
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