/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class HorseBardingNorthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HorseBardingNorthAddonDeed();
			}
		}

		[ Constructable ]
		public HorseBardingNorthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4985 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4984 );
			AddComponent( ac, 0, 1, 0 );

		}

		public HorseBardingNorthAddon( Serial serial ) : base( serial )
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

	public class HorseBardingNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HorseBardingNorthAddon();
			}
		}

		[Constructable]
		public HorseBardingNorthAddonDeed()
		{
			Name = "HorseBardingNorth";
		}

		public HorseBardingNorthAddonDeed( Serial serial ) : base( serial )
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