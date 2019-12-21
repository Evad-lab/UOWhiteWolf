using System;

namespace Server.Items
{
	public class Statue254 : Item
	{
		[Constructable]
		public Statue254() : base( 0x210D )
		{
			Weight = 1.0;
		}

		public Statue254( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}