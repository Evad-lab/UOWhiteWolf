using System;

namespace Server.Items
{
	public class Statue42 : Item
	{
		[Constructable]
		public Statue42() : base( 0x25A9 )
		{
			Weight = 1.0;
		}

		public Statue42( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}