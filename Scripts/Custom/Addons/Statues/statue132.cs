using System;

namespace Server.Items
{
	public class Statue132 : Item
	{
		[Constructable]
		public Statue132() : base( 0x2621 )
		{
			Weight = 1.0;
		}

		public Statue132( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}