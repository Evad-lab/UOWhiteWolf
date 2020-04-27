using System;

namespace Server.Items
{
	public class Statue224 : Item
	{
		[Constructable]
		public Statue224() : base( 0x0ED )
		{
			Weight = 1.0;
		}

		public Statue224( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}