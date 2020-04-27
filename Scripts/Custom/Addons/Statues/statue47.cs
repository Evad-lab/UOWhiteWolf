using System;

namespace Server.Items
{
	public class Statue47 : Item
	{
		[Constructable]
		public Statue47() : base( 0x25AE )
		{
			Weight = 1.0;
		}

		public Statue47( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}