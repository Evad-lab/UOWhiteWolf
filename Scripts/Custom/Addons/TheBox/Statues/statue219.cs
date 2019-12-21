using System;

namespace Server.Items
{
	public class Statue219 : Item
	{
		[Constructable]
		public Statue219() : base( 0x20E8 )
		{
			Weight = 1.0;
		}

		public Statue219( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}