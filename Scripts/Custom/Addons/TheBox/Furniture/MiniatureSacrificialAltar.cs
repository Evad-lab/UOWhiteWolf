using System;
using Server;

namespace Server.Items
{
	public class MiniatureSacrificialAltarAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureSacrificialAltarDeed(); } }

		[Constructable]
		public MiniatureSacrificialAltarAddon()
		{
		    Name = "Miniature Sacrificial Altar";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2AB8 ), 0, 0, 0 );
		}
		
		public MiniatureSacrificialAltarAddon( Serial serial ) : base( serial )
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

	public class MiniatureSacrificialAltarDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureSacrificialAltarAddon(); } }

		[Constructable]
		public MiniatureSacrificialAltarDeed()
		{
		   Name = "Miniature Sacrificial Altar Deed"; 
		}

		public MiniatureSacrificialAltarDeed( Serial serial ) : base( serial )
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