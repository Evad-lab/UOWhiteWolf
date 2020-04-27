using System;

namespace Server.Items
{
	public class Statue246 : Item
	{
		[Constructable]
		public Statue246() : base( 0x2103 )
		{
			Weight = 1.0;
		}

		public Statue246( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}