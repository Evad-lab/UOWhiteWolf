using System;
using Server;

namespace Server.Items
{
	public class MiniatureDisturbingPortraitAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureDisturbingPortraitDeed(); } }

		[Constructable]
		public MiniatureDisturbingPortraitAddon()
		{
		    Name = "Miniature Disturbing Portrait";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2A99 ), 0, 0, 0 );
		}
		
		public MiniatureDisturbingPortraitAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}

	public class MiniatureDisturbingPortraitDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureDisturbingPortraitAddon(); } }

		[Constructable]
		public MiniatureDisturbingPortraitDeed()
		{
		   Name = "Miniature Disturbing Portrait Deed"; 
		}

		public MiniatureDisturbingPortraitDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}