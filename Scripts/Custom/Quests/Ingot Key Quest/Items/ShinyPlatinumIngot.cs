using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyPlatinumIngot : Item 
   { 
      [Constructable] 
      public ShinyPlatinumIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyPlatinumIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Platinum Ingot";
	 Stackable = false;
	 Hue = 1153;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyPlatinumIngot( Serial serial ) : base( serial ) 
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