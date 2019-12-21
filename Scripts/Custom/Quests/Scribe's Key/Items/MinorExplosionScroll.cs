using System; 
using Server; 

namespace Server.Items 
{ 
   public class MinorExplosionScroll : Item 
   { 
      [Constructable] 
      public MinorExplosionScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MinorExplosionScroll( int amount ) : base( 0x1F45 ) 
      {
	 Name = "a minor explosion scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MinorExplosionScroll( Serial serial ) : base( serial ) 
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