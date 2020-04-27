using System;

namespace Server.Items
{
	public class Statue118 : Item
	{
		[Constructable]
		public Statue118() : base( 0x2614 )
		{
			Weight = 1.0;
		}

		public Statue118( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}