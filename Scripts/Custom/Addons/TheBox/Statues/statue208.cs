using System;

namespace Server.Items
{
	public class Statue208 : Item
	{
		[Constructable]
		public Statue208() : base( 0x2D99 )
		{
			Weight = 1.0;
		}

		public Statue208( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}