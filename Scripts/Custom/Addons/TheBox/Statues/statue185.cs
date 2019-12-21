using System;

namespace Server.Items
{
	public class Statue185 : Item
	{
		[Constructable]
		public Statue185() : base( 0x2D96 )
		{
			Weight = 1.0;
		}

		public Statue185( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}