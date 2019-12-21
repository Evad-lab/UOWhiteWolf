
//////////////////////////
//Created by LostSinner//
////////////////////////
using System; 
using Server.Items; 

namespace Server.Items 
{ 
   	public class Letter1: Item 
   	{ 

		[Constructable]
		public Letter1()
		{
			ItemID = 7989;
			Weight = 0.1;
			Name = "Letter to Verona";
			Hue = 1150;
		}

            	public Letter1( Serial serial ) : base ( serial ) 
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