
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class CrestedRing : GoldRing
	{

		[Constructable]
		public CrestedRing()
		{
			Hue = 1157;
			LootType = LootType.Blessed;
			Name = "a Crested Vampires ring";
			
		}

		public CrestedRing( Serial serial ) : base( serial )
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