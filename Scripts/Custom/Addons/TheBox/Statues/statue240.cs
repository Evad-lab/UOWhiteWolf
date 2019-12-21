using System;

namespace Server.Items
{
	public class Statue240 : Item
	{
		[Constructable]
		public Statue240() : base( 0x20FD )
		{
			Weight = 1.0;
		}

		public Statue240( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}