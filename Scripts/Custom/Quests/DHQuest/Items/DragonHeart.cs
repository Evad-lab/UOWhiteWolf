// Scripted by Karmageddon
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class DragonHeart : Item
	{
		[Constructable]
		public DragonHeart() : base( 0xf91 )
		{
			base.Weight = 1.0;
			base.Name = "Dragon Heart";
			base.Hue = 1157;
		}

		public DragonHeart( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}


