
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
	[CorpseName( "Simeon's Corpse" )]
	public class Simeon : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Simeon()
		{
			Name = "Simeon";
                        Title = "the Scientist";
			Body = 400;
			CantWalk = true;
			Hue = 0x83F8;
			AddItem( new Server.Items.Kasa( 996 ) );
			AddItem( new Server.Items.FurSarong( 0 ) );
			AddItem( new Server.Items.Doublet( 0 ) );
			AddItem( new Server.Items.Waraji( 996 ) );
			
			

                        int hairHue = 1150;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



			public Simeon( Serial serial ) : base( serial )
			{
			}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        	{ 
	           	     base.GetContextMenuEntries( from, list ); 
        	   	     list.Add( new SimeonEntry( from, this ) ); 
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

			public class SimeonEntry : ContextMenuEntry
			{	
				private Mobile m_Mobile;
				private Mobile m_Giver;
			
				public SimeonEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
						if ( ! mobile.HasGump( typeof( VampQuestGump9 ) ) )
						{
							{
								Item a = m_Mobile.Backpack.FindItemByType( typeof(MedalionOfFaith) );
								if ( a !=null )
								{
									a.Delete();
									mobile.SendGump( new VampQuestGump9( mobile ));
									mobile.AddToBackpack( new BloodVialBag() );
								}
								else
								{
								m_Mobile.SendMessage( "Can't you see I'm working..." );
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
					if( dropped is VampiresBlood )
					{
						if( dropped.Amount!=20)
						{
							this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "You have gatherd the Blood I needed thank you...", mobile.NetState );
							return false;
						}
				
					dropped.Delete();
					mobile.AddToBackpack( new VampEarrings() );
					mobile.AddToBackpack( new EverClear() );
					mobile.SendGump( new VampQuestGump10(m) );  
										
					
					return true;
         			}
				else if ( dropped is VampiresBlood )
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
	

