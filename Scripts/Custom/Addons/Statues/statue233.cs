using System;

namespace Server.Items
{
	public class Statue233 : Item
	{
		[Constructable]
		public Statue233() : base( 0x20F6 )
		{
			Weight = 1.0;
		}

		public Statue233( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}