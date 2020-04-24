using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyFrostLeather : Item 
   { 
      [Constructable] 
      public SpecialtyFrostLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyFrostLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Frost Leather";
	 Stackable = false;
	 Hue = 93;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyFrostLeather( Serial serial ) : base( serial ) 
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