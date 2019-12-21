using System;

namespace Server.Items
{
	public class Statue193 : Item
	{
		[Constructable]
		public Statue193() : base( 0x20CD )
		{
			Weight = 1.0;
		}

		public Statue193( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}