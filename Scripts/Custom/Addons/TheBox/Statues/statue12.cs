using System;

namespace Server.Items
{
	public class Statue12 : Item
	{
		[Constructable]
		public Statue12() : base( 0x258B )
		{
			Weight = 1.0;
		}

		public Statue12( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}