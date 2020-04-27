using System;

namespace Server.Items
{
	public class Statue105 : Item
	{
		[Constructable]
		public Statue105() : base( 0x2607 )
		{
			Weight = 1.0;
		}

		public Statue105( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}