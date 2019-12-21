using System;

namespace Server.Items
{
	public class Statue218 : Item
	{
		[Constructable]
		public Statue218() : base( 0x20E7 )
		{
			Weight = 1.0;
		}

		public Statue218( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}