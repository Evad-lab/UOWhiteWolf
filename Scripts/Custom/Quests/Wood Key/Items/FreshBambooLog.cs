using System; 
using Server; 

namespace Server.Items 
{ 
   public class FreshBambooLog : Item 
   { 
      [Constructable] 
      public FreshBambooLog() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public FreshBambooLog( int amount ) : base( 0x1BDD ) 
      {
	 Name = "Fresh Bamboo Log";
	 Stackable = false;
	 Hue = 1719;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public FreshBambooLog( Serial serial ) : base( serial ) 
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