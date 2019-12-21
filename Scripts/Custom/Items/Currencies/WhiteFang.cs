//created by Darck... *this is supposed to be a custom currency for use with certian vendor stone setups. simple yet perfect id say*
using System;
using Server;

namespace Server.Items
{
	public class WhiteFang : Item
	{
		public override double DefaultWeight
		{
			get { return 0.001; }
		}

		[Constructable]
		public WhiteFang() : this( 1 )
		{
		}

		[Constructable]
		public WhiteFang( int amount ) : base( 0x5747 )
		{
            Name = "White Fang";
            Hue = 1153; 
			Stackable = true;
			Amount = amount;
		}

		public WhiteFang( Serial serial ) : base( serial )
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