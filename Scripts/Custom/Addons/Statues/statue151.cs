using System;

namespace Server.Items
{
	public class Statue151 : Item
	{
		[Constructable]
		public Statue151() : base( 0x2764 )
		{
			Weight = 1.0;
		}

		public Statue151( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}