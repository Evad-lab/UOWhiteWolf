using System;

namespace Server.Items
{
	public class Statue49 : Item
	{
		[Constructable]
		public Statue49() : base( 0x25B0 )
		{
			Weight = 1.0;
		}

		public Statue49( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}