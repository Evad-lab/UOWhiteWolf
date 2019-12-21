using System;

namespace Server.Items
{
	public class Statue271 : Item
	{
		[Constructable]
		public Statue271() : base( 0x212A )
		{
			Weight = 1.0;
		}

		public Statue271( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}