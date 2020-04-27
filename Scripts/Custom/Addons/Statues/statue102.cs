using System;

namespace Server.Items
{
	public class Statue102 : Item
	{
		[Constructable]
		public Statue102() : base( 0x2604 )
		{
			Weight = 1.0;
		}

		public Statue102( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}