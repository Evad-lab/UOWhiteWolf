using System;

namespace Server.Items
{
	public class Statue182 : Item
	{
		[Constructable]
		public Statue182() : base( 0x2D93 )
		{
			Weight = 1.0;
		}

		public Statue182( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}