using System;

namespace Server.Items
{
	public class Statue201 : Item
	{
		[Constructable]
		public Statue201() : base( 0x20D5 )
		{
			Weight = 1.0;
		}

		public Statue201( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}