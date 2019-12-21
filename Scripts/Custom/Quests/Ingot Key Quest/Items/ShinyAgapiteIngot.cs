using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyAgapiteIngot : Item 
   { 
      [Constructable] 
      public ShinyAgapiteIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyAgapiteIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Agapite Ingot";
	 Stackable = false;
	 Hue = 2425;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyAgapiteIngot( Serial serial ) : base( serial ) 
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