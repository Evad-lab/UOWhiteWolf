
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using Server.Commands;

namespace Server.Mobiles
{
	[CorpseName( "Verona's Corpse" )]
	public class Verona : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Verona()
		{
			Name = "Verona";
                        Title = "Seeker of Vengence";
			Body = 745;
			CantWalk = true;
			Hue = 0x83F8;
			AddItem( new Server.Items.PlainDress( 136 ) );
			AddItem( new Server.Items.HalfApron( 136 ) );
			AddItem( new Server.Items.Sandals( 39 ) );
			
			
			

                        int hairHue = 36;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



			public Verona( Serial serial ) : base( serial )
			{
			}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        	{ 
	           	    base.GetContextMenuEntries( from, list ); 
        	   	    list.Add( new VeronaEntry( from, this ) ); 
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

			public class VeronaEntry : ContextMenuEntry
			{	
				private Mobile m_Mobile;
				private Mobile m_Giver;
			
				public VeronaEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
				{
					m_Mobile = from;
					m_Giver = giver;
				}

				public override void OnClick()
				{	

                          	if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;

					{
						if ( ! mobile.HasGump( typeof( VampQuestGump7 ) ) )
						{
							{
								Item a = m_Mobile.Backpack.FindItemByType( typeof(Letter1) );
								if ( a !=null )
								{
									a.Delete();
									mobile.SendGump( new VampQuestGump7( mobile ));
									mobile.AddToBackpack( new VengenceGemBag() );
								}
								else
								{
								m_Mobile.SendMessage( "Leave me alone *tears falling wildly as she screams..." );
								}
							}
						} 
					}
				}
			}

			public override bool OnDragDrop( Mobile from, Item dropped )
			{          		
         	      	  	Mobile m = from;
				PlayerMobile mobile = m as PlayerMobile;

				if ( mobile != null)
				{
					if( dropped is VengenceGem )
					{
						if( dropped.Amount!=15)
						{
							this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "You have gatherd the gems as I ask thank you.", mobile.NetState );
							return false;
						}
				
					dropped.Delete();
					mobile.AddToBackpack( new VampBracelet() );
					mobile.AddToBackpack( new MedalionOfFaith() );
					mobile.SendGump( new VampQuestGump8(m) );  
										
				
					return true;
         			}
				else if ( dropped is VengenceGem )
				{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         				return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thats Not a Vengence Gem nor nearly enough", mobile.NetState );
     				}
			}
			return false;
		}
	}
}
	

