using System;

namespace Server.Items
{
	public class Statue194 : Item
	{
		[Constructable]
		public Statue194() : base( 0x20CE )
		{
			Weight = 1.0;
		}

		public Statue194( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}