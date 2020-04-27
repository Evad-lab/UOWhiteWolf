using System;

namespace Server.Items
{
	public class Statue168 : Item
	{
		[Constructable]
		public Statue168() : base( 0x281C )
		{
			Weight = 1.0;
		}

		public Statue168( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}