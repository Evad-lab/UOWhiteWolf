using System;

namespace Server.Items
{
	public class Statue123 : Item
	{
		[Constructable]
		public Statue123() : base( 0x2619 )
		{
			Weight = 1.0;
		}

		public Statue123( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}