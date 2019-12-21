using System;

namespace Server.Items
{
	public class Statue174 : Item
	{
		[Constructable]
		public Statue174() : base( 0x2D88 )
		{
			Weight = 1.0;
		}

		public Statue174( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}