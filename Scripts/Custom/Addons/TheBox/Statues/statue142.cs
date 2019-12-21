using System;

namespace Server.Items
{
	public class Statue142 : Item
	{
		[Constructable]
		public Statue142() : base( 0x262B )
		{
			Weight = 1.0;
		}

		public Statue142( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}