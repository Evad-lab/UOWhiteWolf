using System; 
using Server; 

namespace Server.Items 
{ 
   public class WolfTail : Item 
   { 
      [Constructable] 
      public WolfTail() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public WolfTail( int amount ) : base( 0x1E85 ) 
      {
	 Name = "tail of a rapid white wolf";
	 Stackable = true;
	 Hue = 1153;
        	 Weight = 0.1; 
         	 Amount = amount; 
      } 

      public WolfTail( Serial serial ) : base( serial ) 
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