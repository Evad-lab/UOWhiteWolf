using System;

namespace Server.Items
{
	public class Statue96 : Item
	{
		[Constructable]
		public Statue96() : base( 0x25F9 )
		{
			Weight = 1.0;
		}

		public Statue96( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}