using System;
using Server;

namespace Server.Items
{
	public class MiniatureBoneThroneAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureBoneThroneDeed(); } }

		[Constructable]
		public MiniatureBoneThroneAddon()
		{
		    Name = "Miniature Bone Throne";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2A91 ), 0, 0, 0 );
		}
		
		public MiniatureBoneThroneAddon( Serial serial ) : base( serial )
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

	public class MiniatureBoneThroneDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureBoneThroneAddon(); } }

		[Constructable]
		public MiniatureBoneThroneDeed()
		{
		   Name = "Miniature Bone Throne Deed"; 
		}

		public MiniatureBoneThroneDeed( Serial serial ) : base( serial )
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