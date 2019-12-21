using System; 
using Server; 

namespace Server.Items 
{ 
   public class TheNewScribesKey : Item 
   { 
      [Constructable] 
      public TheNewScribesKey() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public TheNewScribesKey( int amount ) : base( 0x42BF ) 
      {
	 Name = "The New Scribe's Key";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public TheNewScribesKey( Serial serial ) : base( serial ) 
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