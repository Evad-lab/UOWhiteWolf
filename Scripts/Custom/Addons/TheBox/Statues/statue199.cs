using System;

namespace Server.Items
{
	public class Statue199 : Item
	{
		[Constructable]
		public Statue199() : base( 0x20D3 )
		{
			Weight = 1.0;
		}

		public Statue199( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}