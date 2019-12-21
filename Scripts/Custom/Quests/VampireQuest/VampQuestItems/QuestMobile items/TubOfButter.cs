
//////////////////////////
//Created by LostSinner//
////////////////////////
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items 
{ 
	
   	public class TubOfButter: Item 
   	{ 
		[Constructable]
		public TubOfButter()
		{
			ItemID = 6190;
			Weight = 0.1;
			Name = "a Flask of Butter";
			Hue = 0;
		}

                private void TubOfButterTarget_Callback( Mobile from, object obj ) 
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
               				if( corpse.Owner is GillesDeRay ) 
               				{
                                		from.AddToBackpack( new CrestedRing() ); 
                     				from.Hits -=70;
						from.SendMessage( "You butter up the dead vampires fingure and slide off the ring" ); 
                     				this.Delete();
						corpse.Delete();
                     					return;
					} 
					else
					{
						from.SendMessage( "Why would you want to use this on that, You Sicko!!" );
					}
				}
				else
				{
					from.SendMessage( "YStop it you Freak!!!" );
				}
            		} 
			else
			{
				from.SendMessage( "Now you're getting twisted" );
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
                                from.BeginTarget( -1, false, TargetFlags.Harmful, new TargetCallback( TubOfButterTarget_Callback ) );
				from.SendMessage( "Target the corpse of GillesDeRay." );
			}         
		}

            	public TubOfButter( Serial serial ) : base ( serial ) 
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