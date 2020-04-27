using System;

namespace Server.Items
{
	public class Statue257 : Item
	{
		[Constructable]
		public Statue257() : base( 0x211A )
		{
			Weight = 1.0;
		}

		public Statue257( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}