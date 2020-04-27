using System;

namespace Server.Items
{
	public class Statue236 : Item
	{
		[Constructable]
		public Statue236() : base( 0x20F9 )
		{
			Weight = 1.0;
		}

		public Statue236( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}