using System;

namespace Server.Items
{
	public class Statue191 : Item
	{
		[Constructable]
		public Statue191() : base( 0x2D9C )
		{
			Weight = 1.0;
		}

		public Statue191( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}