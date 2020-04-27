using System;

namespace Server.Items
{
	public class Statue226 : Item
	{
		[Constructable]
		public Statue226() : base( 0x20EF )
		{
			Weight = 1.0;
		}

		public Statue226( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}