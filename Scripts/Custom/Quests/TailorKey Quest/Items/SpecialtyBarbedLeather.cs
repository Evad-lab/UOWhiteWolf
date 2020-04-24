using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyBarbedLeather : Item 
   { 
      [Constructable] 
      public SpecialtyBarbedLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyBarbedLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Barbed Leather";
	 Stackable = false;
	 Hue = 2129;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyBarbedLeather( Serial serial ) : base( serial ) 
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