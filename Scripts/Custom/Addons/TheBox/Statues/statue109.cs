using System;

namespace Server.Items
{
	public class Statue109 : Item
	{
		[Constructable]
		public Statue109() : base( 0x260B )
		{
			Weight = 1.0;
		}

		public Statue109( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}