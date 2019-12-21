using System;

namespace Server.Items
{
	public class Statue179 : Item
	{
		[Constructable]
		public Statue179() : base( 0x2D8D )
		{
			Weight = 1.0;
		}

		public Statue179( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}