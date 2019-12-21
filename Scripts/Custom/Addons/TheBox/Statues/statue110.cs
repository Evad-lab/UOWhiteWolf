using System;

namespace Server.Items
{
	public class Statue110 : Item
	{
		[Constructable]
		public Statue110() : base( 0x260C )
		{
			Weight = 1.0;
		}

		public Statue110( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}