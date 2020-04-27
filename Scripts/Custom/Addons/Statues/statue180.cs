using System;

namespace Server.Items
{
	public class Statue180 : Item
	{
		[Constructable]
		public Statue180() : base( 0x2D90 )
		{
			Weight = 1.0;
		}

		public Statue180( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}