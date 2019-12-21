
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class BlackHeart1 : Item
	{
		
		[Constructable]
		public BlackHeart1()
		{
			ItemID = 7405;
			Weight = 1.0;
			Name = "a Desiesed Heart";
			Hue = 1055;
		}

		public BlackHeart1( Serial serial ) : base( serial )
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