using System;

namespace Server.Items
{
	public class Statue160 : Item
	{
		[Constructable]
		public Statue160() : base( 0x276D )
		{
			Weight = 1.0;
		}

		public Statue160( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}