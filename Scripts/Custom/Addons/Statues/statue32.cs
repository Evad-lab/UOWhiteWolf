using System;

namespace Server.Items
{
	public class Statue32 : Item
	{
		[Constructable]
		public Statue32() : base( 0x259F )
		{
			Weight = 1.0;
		}

		public Statue32( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}