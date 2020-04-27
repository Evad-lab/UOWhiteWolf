using System;using Server;namespace Server.Items
{
public class LimitedLordBlackthronDoll : Item
{
[Constructable]
public LimitedLordBlackthronDoll() : this( 1 )
{}
[Constructable]
public LimitedLordBlackthronDoll( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
{}
[Constructable]
public LimitedLordBlackthronDoll( int amount ) : base( 9721 )
{
Stackable = false;
Weight = 3.00;
Amount = amount;
Name = "Limited Edition Lord Blackthorn Doll";
Hue = 902;
}
public LimitedLordBlackthronDoll( Serial serial ) : base( serial )
{}
public override void Serialize( GenericWriter writer )
{
base.Serialize( writer );
writer.Write( (int) 0 ); // version
}
public override void Deserialize( GenericReader reader )
{
base.Deserialize( reader ); int version = reader.ReadInt(); }}}
