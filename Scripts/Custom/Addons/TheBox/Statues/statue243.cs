using System;

namespace Server.Items
{
	public class Statue243 : Item
	{
		[Constructable]
		public Statue243() : base( 0x2100 )
		{
			Weight = 1.0;
		}

		public Statue243( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}