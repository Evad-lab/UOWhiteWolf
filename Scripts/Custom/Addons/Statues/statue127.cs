using System;

namespace Server.Items
{
	public class Statue127 : Item
	{
		[Constructable]
		public Statue127() : base( 0x261D )
		{
			Weight = 1.0;
		}

		public Statue127( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}