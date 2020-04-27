using System;

namespace Server.Items
{
	public class Statue148 : Item
	{
		[Constructable]
		public Statue148() : base( 0x2631 )
		{
			Weight = 1.0;
		}

		public Statue148( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}