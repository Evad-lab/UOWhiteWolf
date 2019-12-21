using System;
using Server;

namespace Server.Items
{
	public class MiniatureFountainOfLifeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MiniatureFountainOfLifeDeed(); } }

		[Constructable]
		public MiniatureFountainOfLifeAddon()
		{
		    Name = "Miniature Fountain Of Life";
			Weight = 0.1;
			Movable = true;
			
			AddComponent( new AddonComponent( 0x2AC6 ), 0, 0, 0 );
		}
		
		public MiniatureFountainOfLifeAddon( Serial serial ) : base( serial )
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

	public class MiniatureFountainOfLifeDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MiniatureFountainOfLifeAddon(); } }

		[Constructable]
		public MiniatureFountainOfLifeDeed()
		{
		   Name = "Miniature Fountain Of Life Deed"; 
		}

		public MiniatureFountainOfLifeDeed( Serial serial ) : base( serial )
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