using System;

namespace Server.Items
{
	public class Statue40 : Item
	{
		[Constructable]
		public Statue40() : base( 0x25A7 )
		{
			Weight = 1.0;
		}

		public Statue40( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}