using System;

namespace Server.Items
{
	public class Statue141 : Item
	{
		[Constructable]
		public Statue141() : base( 0x262A )
		{
			Weight = 1.0;
		}

		public Statue141( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}