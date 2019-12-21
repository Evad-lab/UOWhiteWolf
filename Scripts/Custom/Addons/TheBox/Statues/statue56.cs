using System;

namespace Server.Items
{
	public class Statue56 : Item
	{
		[Constructable]
		public Statue56() : base( 0x25B7 )
		{
			Weight = 1.0;
		}

		public Statue56( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}