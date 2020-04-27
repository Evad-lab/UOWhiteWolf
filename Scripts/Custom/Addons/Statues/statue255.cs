using System;

namespace Server.Items
{
	public class Statue255 : Item
	{
		[Constructable]
		public Statue255() : base( 0x2118 )
		{
			Weight = 1.0;
		}

		public Statue255( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}