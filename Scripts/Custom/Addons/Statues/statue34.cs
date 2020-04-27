using System;

namespace Server.Items
{
	public class Statue34 : Item
	{
		[Constructable]
		public Statue34() : base( 0x25A1 )
		{
			Weight = 1.0;
		}

		public Statue34( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}