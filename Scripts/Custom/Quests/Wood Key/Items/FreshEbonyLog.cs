using System; 
using Server; 

namespace Server.Items 
{ 
   public class FreshEbonyLog : Item 
   { 
      [Constructable] 
      public FreshEbonyLog() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public FreshEbonyLog( int amount ) : base( 0x1BDD ) 
      {
	 Name = "Fresh Ebony Log";
	 Stackable = false;
	 Hue = 1457;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public FreshEbonyLog( Serial serial ) : base( serial ) 
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