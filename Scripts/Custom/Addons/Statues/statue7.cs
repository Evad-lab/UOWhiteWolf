using System;

namespace Server.Items
{
	public class Statue7 : Item
	{
		[Constructable]
		public Statue7() : base( 0x2586 )
		{
			Weight = 1.0;
		}

		public Statue7( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}