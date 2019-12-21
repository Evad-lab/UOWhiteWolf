
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class BlueHeart : Item
	{
		
		[Constructable]
		public BlueHeart()
		{
			ItemID = 7405;
			Weight = 1.0;
			Name = "a Ice Cold Heart";
			Hue = 295;
		}

		public BlueHeart( Serial serial ) : base( serial )
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
