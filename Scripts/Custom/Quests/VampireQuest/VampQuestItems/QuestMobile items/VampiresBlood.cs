
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;


namespace Server.Items
{
	public class VampiresBlood : Item
	{
		[Constructable]
		public VampiresBlood() : this( 1 )
		
		{
		}

		[Constructable]
		public VampiresBlood( int amount )
		{
			ItemID = 3620;
			Stackable = true;
			Weight = 1.0;
			Amount = amount;
			Name = "Vial of Vampire's Blood";
			Hue = 1157;
		}

		public VampiresBlood( Serial serial ) : base( serial )
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