using System;

namespace Server.Items
{
	public class Statue19 : Item
	{
		[Constructable]
		public Statue19() : base( 0x2592 )
		{
			Weight = 1.0;
		}

		public Statue19( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}