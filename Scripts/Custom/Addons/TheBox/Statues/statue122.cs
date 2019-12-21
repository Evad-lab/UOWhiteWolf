using System;

namespace Server.Items
{
	public class Statue122 : Item
	{
		[Constructable]
		public Statue122() : base( 0x2618 )
		{
			Weight = 1.0;
		}

		public Statue122( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}