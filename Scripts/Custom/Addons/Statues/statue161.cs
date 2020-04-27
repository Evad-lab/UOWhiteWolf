using System;

namespace Server.Items
{
	public class Statue161 : Item
	{
		[Constructable]
		public Statue161() : base( 0x276E )
		{
			Weight = 1.0;
		}

		public Statue161( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}