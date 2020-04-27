using System;

namespace Server.Items
{
	public class Statue133 : Item
	{
		[Constructable]
		public Statue133() : base( 0x2622 )
		{
			Weight = 1.0;
		}

		public Statue133( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}