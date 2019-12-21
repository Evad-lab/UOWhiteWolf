using System;

namespace Server.Items
{
	public class Statue41 : Item
	{
		[Constructable]
		public Statue41() : base( 0x25A8 )
		{
			Weight = 1.0;
		}

		public Statue41( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}