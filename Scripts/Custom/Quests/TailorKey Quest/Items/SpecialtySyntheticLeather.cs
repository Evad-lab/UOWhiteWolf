using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtySyntheticLeather : Item 
   { 
      [Constructable] 
      public SpecialtySyntheticLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtySyntheticLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Synthetic Leather";
	 Stackable = false;
	 Hue = 1023;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtySyntheticLeather( Serial serial ) : base( serial ) 
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