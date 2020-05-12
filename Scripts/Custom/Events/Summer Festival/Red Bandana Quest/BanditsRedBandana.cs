/* This file was created with
Ilutzio's Questmaker. Enjoy! */
using System;using Server;namespace Server.Items
{
public class BanditsRedBandana : Item
{
[Constructable]
public BanditsRedBandana() : this( 1 )
{}
[Constructable]
public BanditsRedBandana( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
{}
[Constructable]

///////////The hexagon value ont he line below is the ItemID
public BanditsRedBandana( int amount ) : base( 0xC66 )
{


///////////Item name
Name = "Bandit's Red Bandana";

///////////Item hue
Hue = 0x21;

///////////Stackable
Stackable = true;

///////////Weight of one item
Weight = 0.01;
Amount = amount;

QuestItem = true;

}
public BanditsRedBandana( Serial serial ) : base( serial )
{}
public override void Serialize( GenericWriter writer )
{
base.Serialize( writer );
writer.Write( (int) 0 ); // version
}
public override void Deserialize( GenericReader reader )
{
base.Deserialize( reader ); int version = reader.ReadInt(); }}}
