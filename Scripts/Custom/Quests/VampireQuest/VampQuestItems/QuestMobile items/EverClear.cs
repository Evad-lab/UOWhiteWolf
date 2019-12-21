
//////////////////////////
//Created by LostSinner//
////////////////////////
using System; 
using Server.Items; 

namespace Server.Items 
{ 
   	public class EverClear: Item 
   	{ 

		[Constructable]
		public EverClear( )
		{
			ItemID = 2463;
			Weight = 0.1;
			Name = "a bottle of EverClear";
			Hue = 1150;
		
		}

            	public EverClear( Serial serial ) : base ( serial ) 
            	{             
           	} 
            
           	public override void Serialize( GenericWriter writer ) 
           	{ 
              		base.Serialize( writer ); 
              		writer.Write( (int) 0 ); 
           	} 
            
           	public override void Deserialize( GenericReader reader ) 
           	{ 
              		base.Deserialize( reader ); 
              		int version = reader.ReadInt(); 
           	} 
        } 
} 