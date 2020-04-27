using System;

namespace Server.Items
{
	public class Statue158 : Item
	{
		[Constructable]
		public Statue158() : base( 0x276B )
		{
			Weight = 1.0;
		}

		public Statue158( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}