using System;

namespace Server.Items
{
	public class Statue94 : Item
	{
		[Constructable]
		public Statue94() : base( 0x25DD )
		{
			Weight = 1.0;
		}

		public Statue94( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}