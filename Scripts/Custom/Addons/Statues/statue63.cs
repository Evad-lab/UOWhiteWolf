using System;

namespace Server.Items
{
	public class Statue63 : Item
	{
		[Constructable]
		public Statue63() : base( 0x25BE )
		{
			Weight = 1.0;
		}

		public Statue63( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}