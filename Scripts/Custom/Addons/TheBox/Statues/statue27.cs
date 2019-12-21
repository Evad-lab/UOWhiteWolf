using System;

namespace Server.Items
{
	public class Statue27 : Item
	{
		[Constructable]
		public Statue27() : base( 0x259A )
		{
			Weight = 1.0;
		}

		public Statue27( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}