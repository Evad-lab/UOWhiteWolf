using System;

namespace Server.Items
{
	public class Statue16 : Item
	{
		[Constructable]
		public Statue16() : base( 0x258F )
		{
			Weight = 1.0;
		}

		public Statue16( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}