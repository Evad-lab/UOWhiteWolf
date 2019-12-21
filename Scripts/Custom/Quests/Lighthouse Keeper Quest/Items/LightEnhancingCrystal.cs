using System;
using Server.Network;

namespace Server.Items
{
	public class LightEnhancingCrystal : Item
	{
		[Constructable]
		public LightEnhancingCrystal() : base( 0x1F1C )
		{
			Weight = 1.0;
			Hue = 1153;
			Name = "Light Enhancing Crystal";
		}

		public LightEnhancingCrystal( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			from.SendAsciiMessage( "This looks like it could be used in a lighthouse." );
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