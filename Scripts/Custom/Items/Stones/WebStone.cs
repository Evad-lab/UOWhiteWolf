using System; 
using Server.Items; 

namespace Server.Items 
{ 
   public class WebStone : Item 
   { 
      [Constructable] 
      public WebStone() : base( 8786 ) 
      { 
         Movable = true; 
         Hue = 1154; 
         Name = "Web Stone - Read Me"; 
      } 

      public override void OnDoubleClick( Mobile from ) 
      { 
      from.LaunchBrowser( "https://theobsidiantales.com" );//Edit Website Here
      } 

      public WebStone( Serial serial ) : base( serial ) 
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