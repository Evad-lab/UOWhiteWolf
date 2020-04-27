using System;

namespace Server.Items
{
	public class Statue8 : Item
	{
		[Constructable]
		public Statue8() : base( 0x2587 )
		{
			Weight = 1.0;
		}

		public Statue8( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}