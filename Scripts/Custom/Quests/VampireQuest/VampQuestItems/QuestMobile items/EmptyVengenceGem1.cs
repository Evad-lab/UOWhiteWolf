
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using System.Collections;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items 
{ 
	[FlipableAttribute( 0xF52, 0xF51 )]
   	public class EmptyVengenceGem1: Item 
   	{ 
		[Constructable]
		public EmptyVengenceGem1() : base( 0xF52 ) 
		{
			Name = "Empty Vengence Gem";
			ItemID = 3873;
			Weight = 0.1;
			Hue = 1250;
		}

               private void EmptyVengenceGem1Target_Callback( Mobile from, object obj ) 
                { 
			if( from.InRange( this.GetWorldLocation(), 2 ) == false )
			{
				from.SendLocalizedMessage( 500486 );	//That is too far away.
			}
            		else if( obj is Corpse) 
            		{
               			Corpse corpse = (Corpse)obj; 

               			if( corpse.Killer == from ) 
               			{
               				if( corpse.Owner is VampireMage || corpse.Owner is VampireWarrior || corpse.Owner is VampireArcher ) 
               				{
                                		from.AddToBackpack( new VengenceGem() ); 
                     				from.Hits -=70;
						from.SendMessage( "You drain the essence of the Vampire" ); 
                     				this.Delete();
						corpse.Delete();
                     					return;
					} 
					else
					{
						from.SendMessage( "This corpse is not a Vampire's corpse!" );
					}
				}
				else
				{
					from.SendMessage( "You did not slay this creature!" );
				}
            		} 
			else
			{
				from.SendMessage( "This is not a corpse!" );
			}
		}

                public override void OnDoubleClick( Mobile from ) 
                { 
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
                        } 
                        else 
                        { 
                                from.BeginTarget( -1, false, TargetFlags.Harmful, new TargetCallback( EmptyVengenceGem1Target_Callback ) );
				from.SendMessage( "Target the corpse of a Vampire." );
			}         
		}

            	public EmptyVengenceGem1( Serial serial ) : base ( serial ) 
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