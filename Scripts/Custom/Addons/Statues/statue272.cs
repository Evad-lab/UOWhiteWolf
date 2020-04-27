using System;

namespace Server.Items
{
	public class Statue272 : Item
	{
		[Constructable]
		public Statue272() : base( 0x212B )
		{
			Weight = 1.0;
		}

		public Statue272( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}