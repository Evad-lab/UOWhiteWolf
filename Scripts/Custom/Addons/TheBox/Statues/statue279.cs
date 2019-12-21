using System;

namespace Server.Items
{
	public class Statue279 : Item
	{
		[Constructable]
		public Statue279() : base( 0x2132 )
		{
			Weight = 1.0;
		}

		public Statue279( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}