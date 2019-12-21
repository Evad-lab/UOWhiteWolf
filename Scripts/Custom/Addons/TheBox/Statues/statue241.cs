using System;

namespace Server.Items
{
	public class Statue241 : Item
	{
		[Constructable]
		public Statue241() : base( 0x20FE )
		{
			Weight = 1.0;
		}

		public Statue241( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}