using System; 
using Server; 

namespace Server.Items 
{ 
   public class MissingBlazeGranite : Item 
   { 
      [Constructable] 
      public MissingBlazeGranite() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MissingBlazeGranite( int amount ) : base( 0x1EA7 ) 
      {
	 Name = "Chunk of Blaze Granite";
	 Stackable = false;
	 Hue = 1161;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MissingBlazeGranite( Serial serial ) : base( serial ) 
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