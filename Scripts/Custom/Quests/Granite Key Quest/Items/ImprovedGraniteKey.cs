using System; 
using Server; 

namespace Server.Items 
{ 
   public class ImprovedGraniteKey : Item 
   { 
      [Constructable] 
      public ImprovedGraniteKey() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ImprovedGraniteKey( int amount ) : base( 0x177C ) 
      {
	 Name = "Improved Granite Key";
	 Hue = 68;
         Weight = 0.1; 

      } 

      public ImprovedGraniteKey( Serial serial ) : base( serial ) 
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