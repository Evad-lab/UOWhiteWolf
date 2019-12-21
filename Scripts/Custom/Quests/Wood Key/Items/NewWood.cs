using System; 
using Server; 

namespace Server.Items 
{ 
   public class NewWood : Item 
   { 
      [Constructable] 
      public NewWood() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public NewWood( int amount ) : base( 0x1BDD ) 
      {
	 Name = "New Wood";
	 Stackable = false;
	 Hue = 1153;
         Weight = 0.1; 

      } 

      public NewWood( Serial serial ) : base( serial ) 
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