using System;

namespace Server.Items
{
	public class Statue115 : Item
	{
		[Constructable]
		public Statue115() : base( 0x2611 )
		{
			Weight = 1.0;
		}

		public Statue115( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}