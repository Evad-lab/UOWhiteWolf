using System;

namespace Server.Items
{
	public class Statue79 : Item
	{
		[Constructable]
		public Statue79() : base( 0x25CE )
		{
			Weight = 1.0;
		}

		public Statue79( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}