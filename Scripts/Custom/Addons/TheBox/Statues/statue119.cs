using System;

namespace Server.Items
{
	public class Statue119 : Item
	{
		[Constructable]
		public Statue119() : base( 0x2615 )
		{
			Weight = 1.0;
		}

		public Statue119( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}