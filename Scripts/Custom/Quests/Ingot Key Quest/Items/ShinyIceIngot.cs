using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyIceIngot : Item 
   { 
      [Constructable] 
      public ShinyIceIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyIceIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Ice Ingot";
	 Stackable = false;
	 Hue = 1152;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyIceIngot( Serial serial ) : base( serial ) 
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