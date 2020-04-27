using System;

namespace Server.Items
{
	public class Statue11 : Item
	{
		[Constructable]
		public Statue11() : base( 0x258A )
		{
			Weight = 1.0;
		}

		public Statue11( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}