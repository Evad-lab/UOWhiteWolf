using System;

namespace Server.Items
{
	public class Statue155 : Item
	{
		[Constructable]
		public Statue155() : base( 0x2768 )
		{
			Weight = 1.0;
		}

		public Statue155( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}