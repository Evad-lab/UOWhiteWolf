using System;

namespace Server.Items
{
	public class Statue217 : Item
	{
		[Constructable]
		public Statue217() : base( 0x20E6 )
		{
			Weight = 1.0;
		}

		public Statue217( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}