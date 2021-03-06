using System; 
using Server; 

namespace Server.Items 
{ 
   public class MinorStrengthScroll : Item 
   { 
      [Constructable] 
      public MinorStrengthScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MinorStrengthScroll( int amount ) : base( 0x1F35 ) 
      {
	 Name = "a minor strength scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MinorStrengthScroll( Serial serial ) : base( serial ) 
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