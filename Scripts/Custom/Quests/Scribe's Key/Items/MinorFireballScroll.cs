using System; 
using Server; 

namespace Server.Items 
{ 
   public class MinorFireballScroll : Item 
   { 
      [Constructable] 
      public MinorFireballScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MinorFireballScroll( int amount ) : base( 0x1F35 ) 
      {
	 Name = "a minor fireball scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MinorFireballScroll( Serial serial ) : base( serial ) 
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