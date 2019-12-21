using System;

namespace Server.Items
{
	public class Statue59 : Item
	{
		[Constructable]
		public Statue59() : base( 0x25BA )
		{
			Weight = 1.0;
		}

		public Statue59( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}