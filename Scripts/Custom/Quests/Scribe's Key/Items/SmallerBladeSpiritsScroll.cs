using System; 
using Server; 

namespace Server.Items 
{ 
   public class SmallerBladeSpiritsScroll : Item 
   { 
      [Constructable] 
      public SmallerBladeSpiritsScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SmallerBladeSpiritsScroll( int amount ) : base( 0x1F36 ) 
      {
	 Name = "a smaller blade spirits scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SmallerBladeSpiritsScroll( Serial serial ) : base( serial ) 
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