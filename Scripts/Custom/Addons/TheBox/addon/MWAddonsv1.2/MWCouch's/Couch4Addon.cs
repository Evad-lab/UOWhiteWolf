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
	public class Couch4Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Couch4AddonDeed();
			}
		}

		[ Constructable ]
		public Couch4Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 2, 0, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, -2, 1, 2 );
			ac = new AddonComponent( 1222 );
			AddComponent( ac, -2, 0, 2 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3125 );
			ac.Hue = 2892;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 5691 );
			ac.Hue = 2892;
			AddComponent( ac, -2, 0, 7 );
			ac = new AddonComponent( 5691 );
			ac.Hue = 2892;
			AddComponent( ac, 2, 0, 7 );
			ac = new AddonComponent( 2922 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 2922 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 2922 );
			ac.Hue = 2892;
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 2, 0, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, -2, 1, 2 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2892;
			AddComponent( ac, -2, 0, 2 );

		}

		public Couch4Addon( Serial serial ) : base( serial )
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

	public class Couch4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Couch4Addon();
			}
		}

		[Constructable]
		public Couch4AddonDeed()
		{
			Name = "Couch4";
		}

		public Couch4AddonDeed( Serial serial ) : base( serial )
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