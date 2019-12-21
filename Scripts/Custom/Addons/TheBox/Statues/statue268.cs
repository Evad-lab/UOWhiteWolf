using System;

namespace Server.Items
{
	public class Statue268 : Item
	{
		[Constructable]
		public Statue268() : base( 0x2125 )
		{
			Weight = 1.0;
		}

		public Statue268( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}