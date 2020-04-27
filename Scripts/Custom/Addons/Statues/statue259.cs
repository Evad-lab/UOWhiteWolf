using System;

namespace Server.Items
{
	public class Statue259 : Item
	{
		[Constructable]
		public Statue259() : base( 0x211C )
		{
			Weight = 1.0;
		}

		public Statue259( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}