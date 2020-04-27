using System;

namespace Server.Items
{
	public class Statue77 : Item
	{
		[Constructable]
		public Statue77() : base( 0x25CC )
		{
			Weight = 1.0;
		}

		public Statue77( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}