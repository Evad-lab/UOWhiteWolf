using System;
using Server.Network;

namespace Server.Items
{
	public class MMQSpores : Item
	{
		[Constructable]
		public MMQSpores() : base( 0x1036 )
		{
			Weight = 1.0;
			Hue = 62;
			Name = "Magical Mushroom Spores";
		}

		public MMQSpores( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			from.SendAsciiMessage( "This looks like it could be used by a Mycologist." );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}