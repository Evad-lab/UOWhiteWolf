using System;

namespace Server.Items
{
	public class Statue216 : Item
	{
		[Constructable]
		public Statue216() : base( 0x20E4 )
		{
			Weight = 1.0;
		}

		public Statue216( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}