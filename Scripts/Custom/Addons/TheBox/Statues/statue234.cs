using System;

namespace Server.Items
{
	public class Statue234 : Item
	{
		[Constructable]
		public Statue234() : base( 0x20F7 )
		{
			Weight = 1.0;
		}

		public Statue234( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}