using System;

namespace Server.Items
{
	public class Statue249 : Item
	{
		[Constructable]
		public Statue249() : base( 0x2108 )
		{
			Weight = 1.0;
		}

		public Statue249( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}