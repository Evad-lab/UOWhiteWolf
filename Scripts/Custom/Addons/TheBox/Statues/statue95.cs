using System;

namespace Server.Items
{
	public class Statue95 : Item
	{
		[Constructable]
		public Statue95() : base( 0x25F8 )
		{
			Weight = 1.0;
		}

		public Statue95( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}