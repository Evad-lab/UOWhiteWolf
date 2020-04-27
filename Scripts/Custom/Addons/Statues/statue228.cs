using System;

namespace Server.Items
{
	public class Statue228 : Item
	{
		[Constructable]
		public Statue228() : base( 0x20F1 )
		{
			Weight = 1.0;
		}

		public Statue228( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}