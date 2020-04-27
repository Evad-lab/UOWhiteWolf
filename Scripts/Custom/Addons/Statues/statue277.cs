using System;

namespace Server.Items
{
	public class Statue277 : Item
	{
		[Constructable]
		public Statue277() : base( 0x2130 )
		{
			Weight = 1.0;
		}

		public Statue277( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}