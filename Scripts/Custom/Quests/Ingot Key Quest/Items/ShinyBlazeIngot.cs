using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyBlazeIngot : Item 
   { 
      [Constructable] 
      public ShinyBlazeIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyBlazeIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Blaze Ingot";
	 Stackable = false;
	 Hue = 1161;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyBlazeIngot( Serial serial ) : base( serial ) 
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