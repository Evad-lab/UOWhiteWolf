using System; 
using Server; 

namespace Server.Items 
{ 
   public class UnlimitedScroll : Item 
   { 
      [Constructable] 
      public UnlimitedScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public UnlimitedScroll( int amount ) : base( 0xEF3 ) 
      {
	 Name = "a scroll of unlimited uses";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public UnlimitedScroll( Serial serial ) : base( serial ) 
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