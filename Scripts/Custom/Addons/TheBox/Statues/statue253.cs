using System;

namespace Server.Items
{
	public class Statue253 : Item
	{
		[Constructable]
		public Statue253() : base( 0x210C )
		{
			Weight = 1.0;
		}

		public Statue253( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}