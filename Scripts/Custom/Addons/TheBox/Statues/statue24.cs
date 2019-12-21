using System;

namespace Server.Items
{
	public class Statue24 : Item
	{
		[Constructable]
		public Statue24() : base( 0x2597 )
		{
			Weight = 1.0;
		}

		public Statue24( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}