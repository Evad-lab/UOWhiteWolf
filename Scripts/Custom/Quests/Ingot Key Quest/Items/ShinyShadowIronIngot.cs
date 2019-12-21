using System; 
using Server; 

namespace Server.Items 
{ 
   public class ShinyShadowIronIngot : Item 
   { 
      [Constructable] 
      public ShinyShadowIronIngot() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ShinyShadowIronIngot( int amount ) : base( 0x1BF1 ) 
      {
	 Name = "Shiny Shadow Iron Ingot";
	 Stackable = false;
	 Hue = 2406;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public ShinyShadowIronIngot( Serial serial ) : base( serial ) 
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