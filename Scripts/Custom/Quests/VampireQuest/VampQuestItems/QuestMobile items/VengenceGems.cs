
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class VengenceGem : Item
	{
		[Constructable]
		public VengenceGem() : this( 1 )
		{
		}


		[Constructable]
		public VengenceGem( int amount ) : base( 0xF21 )
		{
			Weight = 1.0;
			Name = "Vengence Gem";
			Stackable = true;
			Amount = amount;
			Hue = 1157;
		}

		public VengenceGem( Serial serial ) : base( serial )
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