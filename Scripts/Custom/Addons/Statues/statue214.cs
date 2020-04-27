using System;

namespace Server.Items
{
	public class Statue214 : Item
	{
		[Constructable]
		public Statue214() : base( 0x20E2 )
		{
			Weight = 1.0;
		}

		public Statue214( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}