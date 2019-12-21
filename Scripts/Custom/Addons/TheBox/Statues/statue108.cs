using System;

namespace Server.Items
{
	public class Statue108 : Item
	{
		[Constructable]
		public Statue108() : base( 0x260A )
		{
			Weight = 1.0;
		}

		public Statue108( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}