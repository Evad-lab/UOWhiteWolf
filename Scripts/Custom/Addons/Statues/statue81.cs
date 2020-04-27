using System;

namespace Server.Items
{
	public class Statue81 : Item
	{
		[Constructable]
		public Statue81() : base( 0x25D0 )
		{
			Weight = 1.0;
		}

		public Statue81( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}