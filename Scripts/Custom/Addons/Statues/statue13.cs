using System;

namespace Server.Items
{
	public class Statue13 : Item
	{
		[Constructable]
		public Statue13() : base( 0x258C )
		{
			Weight = 1.0;
		}

		public Statue13( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}