using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyEtherealLeather : Item 
   { 
      [Constructable] 
      public SpecialtyEtherealLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyEtherealLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Ethereal Leather";
	 Stackable = false;
	 Hue = 1159;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyEtherealLeather( Serial serial ) : base( serial ) 
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