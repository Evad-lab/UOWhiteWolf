using System;

namespace Server.Items
{
	public class Statue215 : Item
	{
		[Constructable]
		public Statue215() : base( 0x20DE3 )
		{
			Weight = 1.0;
		}

		public Statue215( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}