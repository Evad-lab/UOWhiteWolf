using System; 
using Server; 

namespace Server.Items 
{ 
   public class RestoredIngotKey : Item 
   { 
      [Constructable] 
      public RestoredIngotKey() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public RestoredIngotKey( int amount ) : base( 0x1EB7 ) 
      {
	 Name = "Restored Ingot Key";
	 Hue = 33;
         Weight = 0.1; 

      } 

      public RestoredIngotKey( Serial serial ) : base( serial ) 
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