using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CrystalBullSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CrystalBullSouthAddonDeed();
			}
		}

		[ Constructable ]
		public CrystalBullSouthAddon()
		{
			AddComponent( new AddonComponent( 13825 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 13824 ), 1, 0, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 13824 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 13825 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CrystalBullSouthAddon( Serial serial ) : base( serial )
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

	public class CrystalBullSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CrystalBullSouthAddon();
			}
		}

		[Constructable]
		public CrystalBullSouthAddonDeed()
		{
			Name = "A Deed for a Crystal Bull (facing south)";
		}

		public CrystalBullSouthAddonDeed( Serial serial ) : base( serial )
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
	
	public class CrystalBullEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CrystalBullEastAddonDeed();
			}
		}

		[ Constructable ]
		public CrystalBullEastAddon()
		{
			AddComponent( new AddonComponent( 13822 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 13823 ), 0, 0, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 13822 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 13823 );
			AddComponent( ac, 0, 0, 0 );

		}

		public CrystalBullEastAddon( Serial serial ) : base( serial )
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

	public class CrystalBullEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CrystalBullEastAddon();
			}
		}

		[Constructable]
		public CrystalBullEastAddonDeed()
		{
			Name = "A Deed for a Crystal Bull (facing east)";
		}

		public CrystalBullEastAddonDeed( Serial serial ) : base( serial )
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