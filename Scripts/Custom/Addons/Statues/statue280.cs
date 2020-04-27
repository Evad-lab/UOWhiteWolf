using System;

namespace Server.Items
{
	public class Statue280 : Item
	{
		[Constructable]
		public Statue280() : base( 0x2133 )
		{
			Weight = 1.0;
		}

		public Statue280( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}