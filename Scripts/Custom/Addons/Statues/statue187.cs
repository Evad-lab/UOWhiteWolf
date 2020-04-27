using System;

namespace Server.Items
{
	public class Statue187 : Item
	{
		[Constructable]
		public Statue187() : base( 0x2D98 )
		{
			Weight = 1.0;
		}

		public Statue187( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}