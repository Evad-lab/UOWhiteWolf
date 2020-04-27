using System;

namespace Server.Items
{
	public class Statue176 : Item
	{
		[Constructable]
		public Statue176() : base( 0x2D8A )
		{
			Weight = 1.0;
		}

		public Statue176( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}