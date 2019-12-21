using System;

namespace Server.Items
{
	public class Statue129 : Item
	{
		[Constructable]
		public Statue129() : base( 0x2633 )
		{
			Weight = 1.0;
		}

		public Statue129( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}