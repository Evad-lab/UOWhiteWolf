using System;

namespace Server.Items
{
	public class Statue143 : Item
	{
		[Constructable]
		public Statue143() : base( 0x262C )
		{
			Weight = 1.0;
		}

		public Statue143( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}