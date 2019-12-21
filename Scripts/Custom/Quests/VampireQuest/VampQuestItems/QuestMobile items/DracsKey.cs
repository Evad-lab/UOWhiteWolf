
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Items;

namespace Server.Items 
{ 
   	public class DracsKey : Item 
   	{ 

		[Constructable]
		public DracsKey() : base( 0x176B)
		{
			Weight = 1.0;
			Name = "Key to Draculas Chamber";
			LootType = LootType.Blessed;
			Hue = 1153;
		}

            	public DracsKey( Serial serial ) : base ( serial ) 
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