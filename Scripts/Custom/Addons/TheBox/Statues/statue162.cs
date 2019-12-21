using System;

namespace Server.Items
{
	public class Statue162 : Item
	{
		[Constructable]
		public Statue162() : base( 0x276F )
		{
			Weight = 1.0;
		}

		public Statue162( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}