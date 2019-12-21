using System;

namespace Server.Items
{
	public class Statue126 : Item
	{
		[Constructable]
		public Statue126() : base( 0x261C )
		{
			Weight = 1.0;
		}

		public Statue126( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}