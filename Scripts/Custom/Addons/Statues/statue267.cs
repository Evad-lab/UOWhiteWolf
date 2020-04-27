using System;

namespace Server.Items
{
	public class Statue267 : Item
	{
		[Constructable]
		public Statue267() : base( 0x2124 )
		{
			Weight = 1.0;
		}

		public Statue267( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}