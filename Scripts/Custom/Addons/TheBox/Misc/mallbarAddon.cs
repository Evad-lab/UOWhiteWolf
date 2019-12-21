
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
	public class mallbarAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3213, -1, -2, 0}, {6013, 0, -2, 0}, {6013, 0, -1, 0}// 1	2	3	
			, {6418, 0, 3, 0}, {6416, 0, 1, 0}, {6430, 1, 1, 0}// 4	5	6	
			, {6417, 2, 1, 0}, {6419, 2, 3, 0}, {6430, 1, 3, 0}// 7	8	9	
			, {6428, 2, 2, 0}, {6424, 0, 2, 0}// 10	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new mallbarAddonDeed();
			}
		}

		[ Constructable ]
		public mallbarAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public mallbarAddon( Serial serial ) : base( serial )
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

	public class mallbarAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new mallbarAddon();
			}
		}

		[Constructable]
		public mallbarAddonDeed()
		{
			Name = "mallbar";
		}

		public mallbarAddonDeed( Serial serial ) : base( serial )
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