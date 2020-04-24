
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
	public class DdWWillowTreeBlossomAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3302, 0, 0, 0}, {3303, 0, 0, 0}, {3214, 0, 0, 28}// 1	2	3	
			, {3214, 0, 1, 28}, {3214, 1, 0, 28}, {3214, 1, 1, 28}// 4	5	6	
			, {3214, 0, 0, 20}, {3214, 0, 1, 20}, {3214, 1, 0, 18}// 7	8	9	
			, {3214, 1, 1, 18}// 10	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DdWWillowTreeBlossomAddonDeed();
			}
		}

		[ Constructable ]
		public DdWWillowTreeBlossomAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DdWWillowTreeBlossomAddon( Serial serial ) : base( serial )
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

	public class DdWWillowTreeBlossomAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DdWWillowTreeBlossomAddon();
			}
		}

		[Constructable]
		public DdWWillowTreeBlossomAddonDeed()
		{
			Name = "DdWWillowTreeBlossom";
		}

		public DdWWillowTreeBlossomAddonDeed( Serial serial ) : base( serial )
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