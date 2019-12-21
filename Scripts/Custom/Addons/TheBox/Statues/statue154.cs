using System;

namespace Server.Items
{
	public class Statue154 : Item
	{
		[Constructable]
		public Statue154() : base( 0x2767 )
		{
			Weight = 1.0;
		}

		public Statue154( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}