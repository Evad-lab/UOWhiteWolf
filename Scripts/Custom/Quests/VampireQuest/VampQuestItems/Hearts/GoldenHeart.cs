
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class GoldenHeart : Item
	{
		
		[Constructable]
		public GoldenHeart()
		{
			ItemID = 7405;
			Weight = 1.0;
			Name = "a Golden Heart";
			Hue = 49;
		}

		public GoldenHeart( Serial serial ) : base( serial )
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