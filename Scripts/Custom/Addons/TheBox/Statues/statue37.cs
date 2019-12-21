using System;

namespace Server.Items
{
	public class Statue37 : Item
	{
		[Constructable]
		public Statue37() : base( 0x25A4 )
		{
			Weight = 1.0;
		}

		public Statue37( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}