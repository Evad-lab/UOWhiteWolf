using System;
using VitaNex.Items;
using VitaNex.Mobiles;

namespace Server.Items
{
    public class DonationToken : VendorToken
    {

        [Constructable]
        public DonationToken() : this( 1 )
        {
        }
        [Constructable]
        public DonationToken( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
        {
        }
        [Constructable]
        public DonationToken( int amount ) : base( 0xEED )
        {
            Name = "Donation Token";
			Amount = amount;
			Hue = 115;
        }
        public DonationToken( Serial serial ) : base( serial )
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