using System;

namespace Server.Items
{
	public class Statue101 : Item
	{
		[Constructable]
		public Statue101() : base( 0x2603 )
		{
			Weight = 1.0;
		}

		public Statue101( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}