using System; 
using Server; 

namespace Server.Items 
{ 
   public class MinorLightningScroll : Item 
   { 
      [Constructable] 
      public MinorLightningScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MinorLightningScroll( int amount ) : base( 0x1F35 ) 
      {
	 Name = "a minor lightning scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MinorLightningScroll( Serial serial ) : base( serial ) 
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