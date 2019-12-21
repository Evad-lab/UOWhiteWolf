using System;

namespace Server.Items
{
	public class Statue262 : Item
	{
		[Constructable]
		public Statue262() : base( 0x211F )
		{
			Weight = 1.0;
		}

		public Statue262( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}