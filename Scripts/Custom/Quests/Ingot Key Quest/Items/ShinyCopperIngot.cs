using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyCopperIngot : Item 
   { 
      [Constructable] 
      public ShinyCopperIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyCopperIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Copper Ingot";
	 Stackable = false;
	 Hue = 2413;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyCopperIngot( Serial serial ) : base( serial ) 
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