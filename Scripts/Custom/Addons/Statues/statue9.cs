using System;

namespace Server.Items
{
	public class Statue9 : Item
	{
		[Constructable]
		public Statue9() : base( 0x2588 )
		{
			Weight = 1.0;
		}

		public Statue9( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}