using System;
using VitaNex.Items;
using VitaNex.Mobiles;

namespace Server.Items
{
    public class SummerToken : VendorToken
    {

        [Constructable]
        public SummerToken() : this( 1 )
        {
        }
        [Constructable]
        public SummerToken( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
        {
        }
        [Constructable]
        public SummerToken( int amount ) : base( 0xEED )
        {
            Name = "Summer Event Token";
			Amount = amount;
			Hue = 1260;
        }
        public SummerToken( Serial serial ) : base( serial )
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