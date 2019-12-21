using System;

namespace Server.Items
{
	public class Statue258 : Item
	{
		[Constructable]
		public Statue258() : base( 0x211B )
		{
			Weight = 1.0;
		}

		public Statue258( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}