using System;

namespace Server.Items
{
	public class Statue220 : Item
	{
		[Constructable]
		public Statue220() : base( 0x20E9 )
		{
			Weight = 1.0;
		}

		public Statue220( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}