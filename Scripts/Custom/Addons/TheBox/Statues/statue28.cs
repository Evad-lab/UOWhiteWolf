using System;

namespace Server.Items
{
	public class Statue28 : Item
	{
		[Constructable]
		public Statue28() : base( 0x259B )
		{
			Weight = 1.0;
		}

		public Statue28( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}