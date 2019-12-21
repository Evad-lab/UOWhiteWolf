using System;

namespace Server.Items
{
	public class Statue58 : Item
	{
		[Constructable]
		public Statue58() : base( 0x25B9 )
		{
			Weight = 1.0;
		}

		public Statue58( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}