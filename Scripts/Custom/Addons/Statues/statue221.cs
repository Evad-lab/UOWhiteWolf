using System;

namespace Server.Items
{
	public class Statue221 : Item
	{
		[Constructable]
		public Statue221() : base( 0x20DA )
		{
			Weight = 1.0;
		}

		public Statue221( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}