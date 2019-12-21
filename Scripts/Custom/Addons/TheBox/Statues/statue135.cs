using System;

namespace Server.Items
{
	public class Statue135 : Item
	{
		[Constructable]
		public Statue135() : base( 0x2624 )
		{
			Weight = 1.0;
		}

		public Statue135( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}