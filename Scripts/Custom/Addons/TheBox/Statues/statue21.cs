using System;

namespace Server.Items
{
	public class Statue21 : Item
	{
		[Constructable]
		public Statue21() : base( 0x2594 )
		{
			Weight = 1.0;
		}

		public Statue21( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}