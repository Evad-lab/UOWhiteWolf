using System;

namespace Server.Items
{
	public class Statue212 : Item
	{
		[Constructable]
		public Statue212() : base( 0x20E0 )
		{
			Weight = 1.0;
		}

		public Statue212( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}