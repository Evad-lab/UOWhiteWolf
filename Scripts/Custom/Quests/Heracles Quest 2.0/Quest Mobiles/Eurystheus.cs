using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "Eurystheus's corpse" )]
	public class Eurystheus : Mobile
	{

		[Constructable]
		public Eurystheus()
		{
			Name = "Eurystheus";
			Title = "The Brother";
			Body = 0x190;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();
			InitStats( 31, 41, 51 );

			Blessed = true;

			Utility.AssignRandomHair( this );

			AddItem( new Server.Items.FancyShirt( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.LongPants( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.Boots( Utility.RandomNeutralHue() ) );

			Container pack = new Backpack();
			pack.DropItem( new Gold( 250, 300 ) );
			pack.Movable = false;
			AddItem( pack );
                 

		}

		public Eurystheus( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new EurystheusEntry( from, this ) ); 
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

		public class EurystheusEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public EurystheusEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( EurystheusGump ) ) )
					{
						mobile.SendGump( new EurystheusGump( mobile ));
						mobile.AddToBackpack( new EurystheusBox() );
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
			bool HeraclesQuest = Convert.ToBoolean( acct.GetTag("HeraclesQuest") );

			if ( mobile != null)
			{
				if( dropped is CompleteEurystheusBox )
            
         			{
         				if(dropped.Amount!=1)
         				{
						this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Collect all the Items!", mobile.NetState );
         					return false;
         				}
                                	if ( !HeraclesQuest ) //added account tag check
		                	{
						dropped.Delete(); 
						mobile.AddToBackpack( new TheRingOfEurystheus() );
						mobile.SendMessage( "Thank you! You are now forgiven. So get on with your life." );
                                        	acct.SetTag( "HeraclesQuest", "true" );

				
         		        	}
					else //what to do if account has already been tagged
         				{
         					mobile.SendMessage("You have already been forgiven, therefore you do not need to do my errands again.");
         					mobile.AddToBackpack( new Gold( 500 ) );
         					dropped.Delete();
         				}
         			}

         			else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I do not need that.", mobile.NetState );
     				}
			}
			return false;
		}
	}
}
