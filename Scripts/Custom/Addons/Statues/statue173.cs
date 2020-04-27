using System;

namespace Server.Items
{
	public class Statue173 : Item
	{
		[Constructable]
		public Statue173() : base( 0x2D87 )
		{
			Weight = 1.0;
		}

		public Statue173( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}