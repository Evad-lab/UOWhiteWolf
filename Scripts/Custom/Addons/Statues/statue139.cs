using System;

namespace Server.Items
{
	public class Statue139 : Item
	{
		[Constructable]
		public Statue139() : base( 0x2628 )
		{
			Weight = 1.0;
		}

		public Statue139( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}