
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class MedalionOfFaith : GoldBracelet
	{

		[Constructable]
		public MedalionOfFaith()
		{
			Hue = 1;
			Name = "a Medalion of Faith";
			
		}

		public MedalionOfFaith( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}