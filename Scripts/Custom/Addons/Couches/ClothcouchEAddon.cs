/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ClothcouchEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ClothcouchEAddonDeed();
			}
		}

		[ Constructable ]
		public ClothcouchEAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 10385 );
			ac.Hue = 46;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 10383 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 10380 );
			ac.Hue = 46;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 10385 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 10383 );
			ac.Hue = 46;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 10383 );
			ac.Hue = 46;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 5015 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 3 );
			ac = new AddonComponent( 5031 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 2 );

		}

		public ClothcouchEAddon( Serial serial ) : base( serial )
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

	public class ClothcouchEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ClothcouchEAddon();
			}
		}

		[Constructable]
		public ClothcouchEAddonDeed()
		{
			Name = "ClothcouchE";
		}

		public ClothcouchEAddonDeed( Serial serial ) : base( serial )
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