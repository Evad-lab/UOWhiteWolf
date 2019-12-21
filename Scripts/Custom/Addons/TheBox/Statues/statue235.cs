using System;

namespace Server.Items
{
	public class Statue235 : Item
	{
		[Constructable]
		public Statue235() : base( 0x20F8 )
		{
			Weight = 1.0;
		}

		public Statue235( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}