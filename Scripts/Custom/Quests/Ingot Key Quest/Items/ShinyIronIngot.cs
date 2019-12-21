using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyIronIngot : Item 
   { 
      [Constructable] 
      public ShinyIronIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyIronIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Iron Ingot";
	 Stackable = false;
	 Hue = 0;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyIronIngot( Serial serial ) : base( serial ) 
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