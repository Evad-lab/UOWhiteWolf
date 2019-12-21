using System;

namespace Server.Items
{
	public class Statue244 : Item
	{
		[Constructable]
		public Statue244() : base( 0x2101 )
		{
			Weight = 1.0;
		}

		public Statue244( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}