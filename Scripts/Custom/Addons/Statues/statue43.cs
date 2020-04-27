using System;

namespace Server.Items
{
	public class Statue43 : Item
	{
		[Constructable]
		public Statue43() : base( 0x25AA )
		{
			Weight = 1.0;
		}

		public Statue43( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}