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
	public class WarriorFountainStatueNAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WarriorFountainStatueNAddonDeed();
			}
		}

		[ Constructable ]
		public WarriorFountainStatueNAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, -1, 20 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1092 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1092 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 8116 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 4825 );
			AddComponent( ac, 1, 0, 32 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 1, 0, 31 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 279 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 0, 0 );

		}

		public WarriorFountainStatueNAddon( Serial serial ) : base( serial )
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

	public class WarriorFountainStatueNAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WarriorFountainStatueNAddon();
			}
		}

		[Constructable]
		public WarriorFountainStatueNAddonDeed()
		{
			Name = "WarriorFountainStatueN";
		}

		public WarriorFountainStatueNAddonDeed( Serial serial ) : base( serial )
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