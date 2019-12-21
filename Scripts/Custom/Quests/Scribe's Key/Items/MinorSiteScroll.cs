using System; 
using Server; 

namespace Server.Items 
{ 
   public class MinorSiteScroll : Item 
   { 
      [Constructable] 
      public MinorSiteScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MinorSiteScroll( int amount ) : base( 0x1F2F ) 
      {
	 Name = "a minor site scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MinorSiteScroll( Serial serial ) : base( serial ) 
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