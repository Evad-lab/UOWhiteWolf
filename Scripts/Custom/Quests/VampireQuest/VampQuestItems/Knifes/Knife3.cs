
//////////////////////////
//Created by LostSinner//
////////////////////////
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items 
{ 
	[FlipableAttribute( 0xF52, 0xF51 )]
   	public class VampKnife3: Item 
   	{ 
		[Constructable]
		public VampKnife3() : base( 0xF52 ) 
		{
			ItemID = 2550;
			Weight = 0.1;
			Name = "A BLoodied Blade";
			Hue = 39;
		}

                private void VampKnife3Target_Callback( Mobile from, object obj ) 
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
               				if( corpse.Owner is Zodiac ) 
               				{
                                		from.AddToBackpack( new BloodHeart() );
                     				from.Hits -=70;
						from.SendMessage( "You carve open the monsters chest" ); 
                     				this.Delete();
						corpse.Delete();
                     					return;
					} 
					else
					{
						from.SendMessage( "This corpse is not of Zodiac!" );
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
                                from.BeginTarget( -1, false, TargetFlags.Harmful, new TargetCallback( VampKnife3Target_Callback ) );
				from.SendMessage( "Target the corpse of Zodiac." );
			}         
		}

            	public VampKnife3( Serial serial ) : base ( serial ) 
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