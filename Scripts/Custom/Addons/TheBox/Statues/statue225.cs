using System;

namespace Server.Items
{
	public class Statue225 : Item
	{
		[Constructable]
		public Statue225() : base( 0x20EE )
		{
			Weight = 1.0;
		}

		public Statue225( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}