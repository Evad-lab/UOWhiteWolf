using System;

namespace Server.Items
{
	public class Statue45 : Item
	{
		[Constructable]
		public Statue45() : base( 0x25AC )
		{
			Weight = 1.0;
		}

		public Statue45( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}