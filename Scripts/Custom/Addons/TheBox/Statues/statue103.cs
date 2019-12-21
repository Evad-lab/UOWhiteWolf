using System;

namespace Server.Items
{
	public class Statue103 : Item
	{
		[Constructable]
		public Statue103() : base( 0x2605 )
		{
			Weight = 1.0;
		}

		public Statue103( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}