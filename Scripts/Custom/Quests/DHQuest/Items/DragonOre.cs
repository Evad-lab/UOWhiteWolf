// Scripted by Karmageddon
using System;

namespace Server.Items
{
	public class DragonOre : Item
	{
		[Constructable]
		public DragonOre() : base( 0x19B9 )
		{
			Name = "Dragon Ore";
			Hue= 0x846;
			Weight = 0.1;						
		}

		public DragonOre( Serial serial ) : base( serial )
		{
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