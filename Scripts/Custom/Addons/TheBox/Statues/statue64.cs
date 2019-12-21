using System;

namespace Server.Items
{
	public class Statue64 : Item
	{
		[Constructable]
		public Statue64() : base( 0x25BF )
		{
			Weight = 1.0;
		}

		public Statue64( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}