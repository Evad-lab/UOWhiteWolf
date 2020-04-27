using System;

namespace Server.Items
{
	public class Statue51 : Item
	{
		[Constructable]
		public Statue51() : base( 0x25B2 )
		{
			Weight = 1.0;
		}

		public Statue51( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}