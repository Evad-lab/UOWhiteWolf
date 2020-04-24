using System; 
using Server; 

namespace Server.Items 
{ 
   public class SpecialtyDaemonicLeather : Item 
   { 
      [Constructable] 
      public SpecialtyDaemonicLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SpecialtyDaemonicLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Specialty Daemonic Leather";
	 Stackable = false;
	 Hue = 32;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SpecialtyDaemonicLeather( Serial serial ) : base( serial ) 
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