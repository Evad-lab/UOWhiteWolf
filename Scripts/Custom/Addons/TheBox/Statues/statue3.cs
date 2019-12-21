using System;

namespace Server.Items
{
	public class Statue3 : Item
	{
		[Constructable]
		public Statue3() : base( 0x2581 )
		{
			Weight = 1.0;
		}

		public Statue3( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}