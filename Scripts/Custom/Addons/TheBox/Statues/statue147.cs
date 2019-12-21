using System;

namespace Server.Items
{
	public class Statue147 : Item
	{
		[Constructable]
		public Statue147() : base( 0x2630 )
		{
			Weight = 1.0;
		}

		public Statue147( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}