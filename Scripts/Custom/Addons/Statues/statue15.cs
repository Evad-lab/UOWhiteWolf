using System;

namespace Server.Items
{
	public class Statue15 : Item
	{
		[Constructable]
		public Statue15() : base( 0x258E )
		{
			Weight = 1.0;
		}

		public Statue15( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}