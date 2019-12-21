using System; 
using Server; 

namespace Server.Items 
{ 
   public class WellUsedScribesPen : Item 
   { 
      [Constructable] 
      public WellUsedScribesPen() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public WellUsedScribesPen( int amount ) : base( 0xFBF ) 
      {
	 Name = "Well Used Scribe's Pen";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public WellUsedScribesPen( Serial serial ) : base( serial ) 
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