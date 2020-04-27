using System;

namespace Server.Items
{
	public class Statue166 : Item
	{
		[Constructable]
		public Statue166() : base( 0x2773 )
		{
			Weight = 1.0;
		}

		public Statue166( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}