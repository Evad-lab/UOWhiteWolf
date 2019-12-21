using System;

namespace Server.Items
{
	public class Statue111 : Item
	{
		[Constructable]
		public Statue111() : base( 0x260D )
		{
			Weight = 1.0;
		}

		public Statue111( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}