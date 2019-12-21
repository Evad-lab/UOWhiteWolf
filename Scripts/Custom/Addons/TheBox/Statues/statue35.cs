using System;

namespace Server.Items
{
	public class Statue35 : Item
	{
		[Constructable]
		public Statue35() : base( 0x25A2 )
		{
			Weight = 1.0;
		}

		public Statue35( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}