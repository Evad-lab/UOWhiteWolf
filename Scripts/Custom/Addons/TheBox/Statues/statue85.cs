using System;

namespace Server.Items
{
	public class Statue85 : Item
	{
		[Constructable]
		public Statue85() : base( 0x25D4 )
		{
			Weight = 1.0;
		}

		public Statue85( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}