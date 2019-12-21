using System;

namespace Server.Items
{
	public class Statue248 : Item
	{
		[Constructable]
		public Statue248() : base( 0x2107 )
		{
			Weight = 1.0;
		}

		public Statue248( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}