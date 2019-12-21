using System; 
using Server; 

namespace Server.Items 
{ 
   public class FreshPetrifiedLog : Item 
   { 
      [Constructable] 
      public FreshPetrifiedLog() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public FreshPetrifiedLog( int amount ) : base( 0x1BDD ) 
      {
	 Name = "Fresh Petrified Log";
	 Stackable = false;
	 Hue = 1153;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public FreshPetrifiedLog( Serial serial ) : base( serial ) 
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