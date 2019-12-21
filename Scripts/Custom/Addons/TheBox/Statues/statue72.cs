using System;

namespace Server.Items
{
	public class Statue72 : Item
	{
		[Constructable]
		public Statue72() : base( 0x25C7 )
		{
			Weight = 1.0;
		}

		public Statue72( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}