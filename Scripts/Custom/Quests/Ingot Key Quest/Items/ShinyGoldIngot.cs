using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyGoldIngot : Item 
   { 
      [Constructable] 
      public ShinyGoldIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyGoldIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Gold Ingot";
	 Stackable = false;
	 Hue = 2213;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyGoldIngot( Serial serial ) : base( serial ) 
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