using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyLeather : Item 
   { 
      [Constructable] 
      public SpecialtyLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Leather";
	 Stackable = false;
	 Hue = 0;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyLeather( Serial serial ) : base( serial ) 
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