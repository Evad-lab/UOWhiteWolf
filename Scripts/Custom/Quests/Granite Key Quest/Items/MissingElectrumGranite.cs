using System; 
using Server; 

namespace Server.Items 
{ 
   public class MissingElectrumGranite : Item 
   { 
      [Constructable] 
      public MissingElectrumGranite() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MissingElectrumGranite( int amount ) : base( 0x4B4B ) 
      {
	 Name = "Captivating Electrum Piece";
	 Stackable = false;
	 Hue = 1278;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MissingElectrumGranite( Serial serial ) : base( serial ) 
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