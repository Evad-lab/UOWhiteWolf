using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyToxicIngot : Item 
   { 
      [Constructable] 
      public ShinyToxicIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyToxicIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Toxic Ingot";
	 Stackable = false;
	 Hue = 1272;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyToxicIngot( Serial serial ) : base( serial ) 
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