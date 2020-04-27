using System;

namespace Server.Items
{
	public class Statue237 : Item
	{
		[Constructable]
		public Statue237() : base( 0x20FA )
		{
			Weight = 1.0;
		}

		public Statue237( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}