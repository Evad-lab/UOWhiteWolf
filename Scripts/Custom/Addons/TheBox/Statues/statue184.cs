using System;

namespace Server.Items
{
	public class Statue184 : Item
	{
		[Constructable]
		public Statue184() : base( 0x2D95 )
		{
			Weight = 1.0;
		}

		public Statue184( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}