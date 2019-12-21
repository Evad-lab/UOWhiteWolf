using System;

namespace Server.Items
{
	public class Statue86 : Item
	{
		[Constructable]
		public Statue86() : base( 0x25D5 )
		{
			Weight = 1.0;
		}

		public Statue86( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}