using System;

namespace Server.Items
{
	public class Statue66 : Item
	{
		[Constructable]
		public Statue66() : base( 0x25C1 )
		{
			Weight = 1.0;
		}

		public Statue66( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}