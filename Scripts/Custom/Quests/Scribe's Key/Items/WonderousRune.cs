using System; 
using Server; 

namespace Server.Items 
{ 
   public class WonderousRune : Item 
   { 
      [Constructable] 
      public WonderousRune() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public WonderousRune( int amount ) : base( 0x1F14 ) 
      {
	 Name = "a wonderous rune";
	 Stackable = false;
	 Hue = 1161;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public WonderousRune ( Serial serial ) : base( serial ) 
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