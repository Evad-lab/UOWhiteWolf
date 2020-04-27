using System;

namespace Server.Items
{
	public class Statue97 : Item
	{
		[Constructable]
		public Statue97() : base( 0x25FA )
		{
			Weight = 1.0;
		}

		public Statue97( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}