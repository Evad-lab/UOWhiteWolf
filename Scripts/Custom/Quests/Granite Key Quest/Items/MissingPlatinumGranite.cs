using System; 
using Server; 

namespace Server.Items 
{ 
   public class MissingPlatinumGranite : Item 
   { 
      [Constructable] 
      public MissingPlatinumGranite() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MissingPlatinumGranite( int amount ) : base( 0x1360 ) 
      {
	 Name = "Glorious Platinum Specimen";
	 Stackable = false;
	 Hue = 1153;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MissingPlatinumGranite( Serial serial ) : base( serial ) 
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