using System;

namespace Server.Items
{
	public class Statue69 : Item
	{
		[Constructable]
		public Statue69() : base( 0x25C4 )
		{
			Weight = 1.0;
		}

		public Statue69( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}