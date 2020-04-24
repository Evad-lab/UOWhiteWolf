using System; 
using Server; 

namespace Server.Items 
{ 
   public class NewSewingBasketKey : Item 
   { 
      [Constructable] 
      public NewSewingBasketKey() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public NewSewingBasketKey( int amount ) : base( 0xF9D ) 
      {
	 Name = "New Sewing Basket";
	 Hue = 1166;
         Weight = 0.1; 

      } 

      public NewSewingBasketKey( Serial serial ) : base( serial ) 
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