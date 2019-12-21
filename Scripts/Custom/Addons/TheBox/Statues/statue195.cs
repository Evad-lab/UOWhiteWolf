using System;

namespace Server.Items
{
	public class Statue195 : Item
	{
		[Constructable]
		public Statue195() : base( 0x20CF )
		{
			Weight = 1.0;
		}

		public Statue195( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}