using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyShadowLeather : Item 
   { 
      [Constructable] 
      public SpecialtyShadowLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyShadowLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Shadow Leather";
	 Stackable = false;
	 Hue = 2406;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyShadowLeather( Serial serial ) : base( serial ) 
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