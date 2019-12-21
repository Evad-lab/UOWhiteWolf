using System;

namespace Server.Items
{
	public class Statue61 : Item
	{
		[Constructable]
		public Statue61() : base( 0x25BC )
		{
			Weight = 1.0;
		}

		public Statue61( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}