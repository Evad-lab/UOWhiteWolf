
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
	public class Halloween_Rack_SouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4695, 0, 2, 0}, {4694, 1, 2, 0}, {4701, 1, -1, 0}// 1	2	3	
			, {4700, 0, -1, 0}, {4699, 0, 0, 0}, {4698, 1, 0, 0}// 4	5	6	
			, {4697, 1, 1, 0}, {4696, 0, 1, 0}// 7	8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Halloween_Rack_SouthAddonDeed();
			}
		}

		[ Constructable ]
		public Halloween_Rack_SouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Halloween_Rack_SouthAddon( Serial serial ) : base( serial )
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

	public class Halloween_Rack_SouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Halloween_Rack_SouthAddon();
			}
		}

		[Constructable]
		public Halloween_Rack_SouthAddonDeed()
		{
			Name = "Halloween_Rack_South";
		}

		public Halloween_Rack_SouthAddonDeed( Serial serial ) : base( serial )
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