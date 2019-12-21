using System; 
using Server; 

namespace Server.Items 
{ 
   public class SmallMeteorSwarmScroll : Item 
   { 
      [Constructable] 
      public SmallMeteorSwarmScroll() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SmallMeteorSwarmScroll( int amount ) : base( 0x1F36 ) 
      {
	 Name = "a small meteor swarm scroll";
	 Stackable = false;
	 Weight = 1.0; 
         Amount = amount; 
      } 

      public SmallMeteorSwarmScroll( Serial serial ) : base( serial ) 
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