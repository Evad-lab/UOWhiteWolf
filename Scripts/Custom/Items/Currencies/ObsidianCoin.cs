//created by Darck... *this is supposed to be a custom currency for use with certian vendor stone setups. simple yet perfect id say*
using System;
using Server;

namespace Server.Items
{
	public class ObsidianCoin : Item
	{
		public override double DefaultWeight
		{
			get { return 0.001; }
		}

		[Constructable]
		public ObsidianCoin() : this( 1 )
		{
		}

		[Constructable]
		public ObsidianCoin( int amount ) : base( 0x3196 )
		{
            Name = "Obsidian Coin";
            Hue = 1954; 
			Stackable = true;
			Amount = amount;
		}

		public ObsidianCoin( Serial serial ) : base( serial )
		{
		}

        public override int GetDropSound()
        {
            if (Amount <= 1)
                return 0x2E4;
            else if (Amount <= 5)
                return 0x2E5;
            else
                return 0x2E6;
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