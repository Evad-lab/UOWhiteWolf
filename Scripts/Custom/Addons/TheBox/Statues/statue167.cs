using System;

namespace Server.Items
{
	public class Statue167 : Item
	{
		[Constructable]
		public Statue167() : base( 0x281B )
		{
			Weight = 1.0;
		}

		public Statue167( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}