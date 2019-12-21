using System;

namespace Server.Items
{
	public class Statue125 : Item
	{
		[Constructable]
		public Statue125() : base( 0x261B )
		{
			Weight = 1.0;
		}

		public Statue125( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}