using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyBronzeIngot : Item 
   { 
      [Constructable] 
      public ShinyBronzeIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyBronzeIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Iron Ingot";
	 Stackable = false;
	 Hue = 2418;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyBronzeIngot( Serial serial ) : base( serial ) 
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