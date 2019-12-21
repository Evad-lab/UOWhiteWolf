using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyVeriteIngot : Item 
   { 
      [Constructable] 
      public ShinyVeriteIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyVeriteIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Verite Ingot";
	 Stackable = false;
	 Hue = 2207;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyVeriteIngot( Serial serial ) : base( serial ) 
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