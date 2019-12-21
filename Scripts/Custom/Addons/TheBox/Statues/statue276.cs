using System;

namespace Server.Items
{
	public class Statue276 : Item
	{
		[Constructable]
		public Statue276() : base( 0x212F )
		{
			Weight = 1.0;
		}

		public Statue276( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}