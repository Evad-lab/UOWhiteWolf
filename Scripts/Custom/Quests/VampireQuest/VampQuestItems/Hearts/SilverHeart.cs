
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class SilverHeart : Item
	{
		
		[Constructable]
		public SilverHeart()
		{
			ItemID = 7405;
			Weight = 1.0;
			Name = "a Glimmering Heart";
			Hue = 906;
		}

		public SilverHeart( Serial serial ) : base( serial )
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