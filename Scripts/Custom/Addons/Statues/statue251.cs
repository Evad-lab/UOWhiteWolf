using System;

namespace Server.Items
{
	public class Statue251 : Item
	{
		[Constructable]
		public Statue251() : base( 0x210A )
		{
			Weight = 1.0;
		}

		public Statue251( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}