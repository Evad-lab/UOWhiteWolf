using System; 
using Server; 

namespace Server.Items 
{ 
   public class AlmostNotDeadScroll : Item 
   { 
      [Constructable] 
      public AlmostNotDeadScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public AlmostNotDeadScroll( int amount ) : base( 0x1F2F ) 
      {
	 Name = "almost not dead scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public AlmostNotDeadScroll( Serial serial ) : base( serial ) 
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