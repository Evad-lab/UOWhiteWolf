using System;

namespace Server.Items
{
	public class Statue100 : Item
	{
		[Constructable]
		public Statue100() : base( 0x2602 )
		{
			Weight = 1.0;
		}

		public Statue100( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}