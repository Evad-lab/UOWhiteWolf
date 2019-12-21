using System;

namespace Server.Items
{
	public class Statue281 : Item
	{
		[Constructable]
		public Statue281() : base( 0x2134 )
		{
			Weight = 1.0;
		}

		public Statue281( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}