using System;

namespace Server.Items
{
	public class Statue4 : Item
	{
		[Constructable]
		public Statue4() : base( 0x2582 )
		{
			Weight = 1.0;
		}

		public Statue4( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}