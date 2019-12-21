using System;

namespace Server.Items
{
	public class Statue186 : Item
	{
		[Constructable]
		public Statue186() : base( 0x2D97 )
		{
			Weight = 1.0;
		}

		public Statue186( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}