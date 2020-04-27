using System;

namespace Server.Items
{
	public class Statue209 : Item
	{
		[Constructable]
		public Statue209() : base( 0x20DD )
		{
			Weight = 1.0;
		}

		public Statue209( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}