using System;

namespace Server.Items
{
	public class Statue29 : Item
	{
		[Constructable]
		public Statue29() : base( 0x259C )
		{
			Weight = 1.0;
		}

		public Statue29( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}