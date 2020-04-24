using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyHornedLeather : Item 
   { 
      [Constructable] 
      public SpecialtyHornedLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyHornedLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Horned Leather";
	 Stackable = false;
	 Hue = 2117;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyHornedLeather( Serial serial ) : base( serial ) 
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