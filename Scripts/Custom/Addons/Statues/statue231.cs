using System;

namespace Server.Items
{
	public class Statue231 : Item
	{
		[Constructable]
		public Statue231() : base( 0x20F4 )
		{
			Weight = 1.0;
		}

		public Statue231( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}