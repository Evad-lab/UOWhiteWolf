using System;

namespace Server.Items
{
	public class Statue245 : Item
	{
		[Constructable]
		public Statue245() : base( 0x2102 )
		{
			Weight = 1.0;
		}

		public Statue245( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}