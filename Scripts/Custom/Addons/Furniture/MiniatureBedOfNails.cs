using System;
using Server;

namespace Server.Items
{
	public class MiniatureBedOfNailsAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureBedOfNailsDeed(); } }

		[Constructable]
		public MiniatureBedOfNailsAddon()
		{
		    Name = "Miniature Bed Of Nails";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2A92 ), 0, 0, 0 );
		}
		
		public MiniatureBedOfNailsAddon( Serial serial ) : base( serial )
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

	public class MiniatureBedOfNailsDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureBedOfNailsAddon(); } }

		[Constructable]
		public MiniatureBedOfNailsDeed()
		{
		   Name = "Miniature Bed Of Nails Deed"; 
		}

		public MiniatureBedOfNailsDeed( Serial serial ) : base( serial )
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