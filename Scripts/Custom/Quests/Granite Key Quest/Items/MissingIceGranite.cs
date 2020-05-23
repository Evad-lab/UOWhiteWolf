using System; 
using Server; 

namespace Server.Items 
{ 
   public class MissingIceGranite : Item 
   { 
      [Constructable] 
      public MissingIceGranite() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MissingIceGranite( int amount ) : base( 0x5732 ) 
      {
	 Name = "Cold as Ice Piece";
	 Stackable = false;
	 Hue = 1152;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MissingIceGranite( Serial serial ) : base( serial ) 
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