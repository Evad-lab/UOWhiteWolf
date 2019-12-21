using System;
using Server;

namespace Server.Items
{
	public class MiniatureHauntedMirrorAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureHauntedMirrorDeed(); } }

		[Constructable]
		public MiniatureHauntedMirrorAddon()
		{
		    Name = "Miniature Haunted Mirror";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2A98 ), 0, 0, 0 );
		}
		
		public MiniatureHauntedMirrorAddon( Serial serial ) : base( serial )
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

	public class MiniatureHauntedMirrorDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureHauntedMirrorAddon(); } }

		[Constructable]
		public MiniatureHauntedMirrorDeed()
		{
		   Name = "Miniature Haunted Mirror Deed"; 
		}

		public MiniatureHauntedMirrorDeed( Serial serial ) : base( serial )
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