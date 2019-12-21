using System; 
using Server; 

namespace Server.Items 
{ 
   public class FreshPurpleHeartLog : Item 
   { 
      [Constructable] 
      public FreshPurpleHeartLog() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public FreshPurpleHeartLog( int amount ) : base( 0x1BDD ) 
      {
	 Name = "Fresh PurpleHeart Log";
	 Stackable = false;
	 Hue = 114;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public FreshPurpleHeartLog( Serial serial ) : base( serial ) 
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