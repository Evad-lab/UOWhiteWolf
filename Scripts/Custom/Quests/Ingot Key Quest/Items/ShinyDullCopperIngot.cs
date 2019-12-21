using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyDullCopperIngot : Item 
   { 
      [Constructable] 
      public ShinyDullCopperIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyDullCopperIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Dull Copper Ingot";
	 Stackable = false;
	 Hue = 2419;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyDullCopperIngot( Serial serial ) : base( serial ) 
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