using System;

namespace Server.Items
{
	public class Statue31 : Item
	{
		[Constructable]
		public Statue31() : base( 0x259E )
		{
			Weight = 1.0;
		}

		public Statue31( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}