using System;

namespace Server.Items
{
	public class Statue190 : Item
	{
		[Constructable]
		public Statue190() : base( 0x2D9B )
		{
			Weight = 1.0;
		}

		public Statue190( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}