using System;

namespace Server.Items
{
	public class Statue152 : Item
	{
		[Constructable]
		public Statue152() : base( 0x2765 )
		{
			Weight = 1.0;
		}

		public Statue152( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}