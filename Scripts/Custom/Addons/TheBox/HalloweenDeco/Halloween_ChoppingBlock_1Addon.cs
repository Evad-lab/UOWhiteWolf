
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
	public class Halloween_ChoppingBlock_1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4721, -1, 1, 0}, {4720, 0, 1, 0}, {4715, 1, 1, 0}// 1	2	3	
			, {4723, -1, -1, 0}, {4722, -1, 0, 0}, {4719, 0, 0, 0}// 4	5	6	
			, {4718, 0, -1, 0}, {4717, 1, -1, 0}, {4716, 1, 0, 0}// 7	8	9	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Halloween_ChoppingBlock_1AddonDeed();
			}
		}

		[ Constructable ]
		public Halloween_ChoppingBlock_1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Halloween_ChoppingBlock_1Addon( Serial serial ) : base( serial )
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

	public class Halloween_ChoppingBlock_1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Halloween_ChoppingBlock_1Addon();
			}
		}

		[Constructable]
		public Halloween_ChoppingBlock_1AddonDeed()
		{
			Name = "Halloween_ChoppingBlock_1";
		}

		public Halloween_ChoppingBlock_1AddonDeed( Serial serial ) : base( serial )
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