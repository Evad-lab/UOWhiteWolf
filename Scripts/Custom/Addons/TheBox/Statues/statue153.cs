using System;

namespace Server.Items
{
	public class Statue153 : Item
	{
		[Constructable]
		public Statue153() : base( 0x2766 )
		{
			Weight = 1.0;
		}

		public Statue153( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}