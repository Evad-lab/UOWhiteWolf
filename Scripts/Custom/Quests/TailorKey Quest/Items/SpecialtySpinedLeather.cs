using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtySpinedLeather : Item 
   { 
      [Constructable] 
      public SpecialtySpinedLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtySpinedLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Spined Leather";
	 Stackable = false;
	 Hue = 2220;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtySpinedLeather( Serial serial ) : base( serial ) 
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