using System;

namespace Server.Items
{
	public class Statue73 : Item
	{
		[Constructable]
		public Statue73() : base( 0x25C8 )
		{
			Weight = 1.0;
		}

		public Statue73( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}