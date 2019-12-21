using System;

namespace Server.Items
{
	public class Statue170 : Item
	{
		[Constructable]
		public Statue170() : base( 0x2D83 )
		{
			Weight = 1.0;
		}

		public Statue170( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}