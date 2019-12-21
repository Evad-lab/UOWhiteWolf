using System;

namespace Server.Items
{
	public class Statue107 : Item
	{
		[Constructable]
		public Statue107() : base( 0x2609 )
		{
			Weight = 1.0;
		}

		public Statue107( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}