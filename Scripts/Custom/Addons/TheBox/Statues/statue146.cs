using System;

namespace Server.Items
{
	public class Statue146 : Item
	{
		[Constructable]
		public Statue146() : base( 0x262F )
		{
			Weight = 1.0;
		}

		public Statue146( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}