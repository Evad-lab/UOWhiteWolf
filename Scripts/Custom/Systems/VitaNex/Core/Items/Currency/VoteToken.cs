using System;
using VitaNex.Items;
using VitaNex.Mobiles;

namespace Server.Items
{
    public class VoteToken : VendorToken
    {

        [Constructable]
        public VoteToken() : this( 1 )
        {
        }
        [Constructable]
        public VoteToken( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
        {
        }
        [Constructable]
        public VoteToken( int amount ) : base( 0xEED )
        {
            Name = "Vote Token";
			Amount = amount;
			Hue = 1159;
        }
        public VoteToken( Serial serial ) : base( serial )
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