using System; 
using Server; 

namespace Server.Items 
{ 
   public class WolfTongue : Item 
   { 
      [Constructable] 
      public WolfTongue() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public WolfTongue( int amount ) : base( 0xF85 ) 
      {
	 Name = "tongue of a greater white wolf";
	 Stackable = true;
	 Hue = 36;
        	 Weight = 0.1; 
         	 Amount = amount; 
      } 

      public WolfTongue( Serial serial ) : base( serial ) 
      { 
      } 

      //public override Item Dupe( int amount ) 
      //{ 
         //return base.Dupe( new WolfTail( amount ), amount ); 
      //} 

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