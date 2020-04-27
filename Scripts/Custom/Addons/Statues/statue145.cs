using System;

namespace Server.Items
{
	public class Statue145 : Item
	{
		[Constructable]
		public Statue145() : base( 0x262E )
		{
			Weight = 1.0;
		}

		public Statue145( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}