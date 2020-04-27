using System;

namespace Server.Items
{
	public class Statue177 : Item
	{
		[Constructable]
		public Statue177() : base( 0x2D8B )
		{
			Weight = 1.0;
		}

		public Statue177( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}