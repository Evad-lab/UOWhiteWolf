using System; 
using Server; 

namespace Server.Items 
{ 
   public class CrocEgg : Item 
   { 
      [Constructable] 
      public CrocEgg() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public CrocEgg( int amount ) : base( 5926 ) 
      {
	 Name = "A Croc Egg";
	 Stackable = false;
	 Hue = 1153;
        	 Weight = 1.0; 
         	 Amount = amount; 
      } 

      public CrocEgg( Serial serial ) : base( serial ) 
      { 
      } 

      //public override Item Dupe( int amount ) 
      //{ 
         //return base.Dupe( new CrocEgg( amount ), amount ); 
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