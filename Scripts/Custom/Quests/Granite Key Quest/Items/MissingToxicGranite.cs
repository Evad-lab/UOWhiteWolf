using System; 
using Server; 

namespace Server.Items 
{ 
   public class MissingToxicGranite : Item 
   { 
      [Constructable] 
      public MissingToxicGranite() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MissingToxicGranite( int amount ) : base( 0x1368 ) 
      {
	 Name = "Cold as Ice Piece";
	 Stackable = false;
	 Hue = 1272;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public MissingToxicGranite( Serial serial ) : base( serial ) 
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