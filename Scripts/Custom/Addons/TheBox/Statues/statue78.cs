using System;

namespace Server.Items
{
	public class Statue78 : Item
	{
		[Constructable]
		public Statue78() : base( 0x25CD )
		{
			Weight = 1.0;
		}

		public Statue78( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}