using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyValoriteIngot : Item 
   { 
      [Constructable] 
      public ShinyValoriteIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyValoriteIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Valorite Ingot";
	 Stackable = false;
	 Hue = 2219;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyValoriteIngot( Serial serial ) : base( serial ) 
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