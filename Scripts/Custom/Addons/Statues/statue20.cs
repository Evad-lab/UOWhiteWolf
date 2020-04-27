using System;

namespace Server.Items
{
	public class Statue20 : Item
	{
		[Constructable]
		public Statue20() : base( 0x2593 )
		{
			Weight = 1.0;
		}

		public Statue20( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}