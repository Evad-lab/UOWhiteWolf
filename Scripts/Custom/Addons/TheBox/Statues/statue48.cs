using System;

namespace Server.Items
{
	public class Statue48 : Item
	{
		[Constructable]
		public Statue48() : base( 0x25AF )
		{
			Weight = 1.0;
		}

		public Statue48( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}