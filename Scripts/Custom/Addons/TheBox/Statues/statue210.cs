using System;

namespace Server.Items
{
	public class Statue210 : Item
	{
		[Constructable]
		public Statue210() : base( 0x20DE )
		{
			Weight = 1.0;
		}

		public Statue210( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}