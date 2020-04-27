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
	[CorpseName( "a Legendary Tailor's corpse" )]
	public class MarmaladeTheTailor : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public MarmaladeTheTailor()
		{
			Name = "Marmalade";
                        Title = "the Legendary Seamstress [?]";
			Body = 0x191;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();

			Utility.AssignRandomHair( this );

			AddItem( new Server.Items.PlainDress( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.Boots( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.SkullCap( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.FullApron( Utility.RandomNeutralHue() ) );

			Container pack = new Backpack();
			pack.DropItem( new Gold( 250, 300 ) );
			pack.Movable = false;
			AddItem( pack );

		}

		public MarmaladeTheTailor( Serial serial ) 
		        : base( serial )
		{
		}
		
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new MarmaladeTheTailorEntry( from, this ) ); 
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

		public class MarmaladeTheTailorEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public MarmaladeTheTailorEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( MarmaladeTheTailorGump ) ) )
					{
						mobile.SendGump( new MarmaladeTheTailorGump( mobile ));
						mobile.AddToBackpack( new OldSewingBasketKey() );
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
			bool NewSewingBasketKeyReceived = Convert.ToBoolean( acct.GetTag("NewSewingBasketReceived") );

			if ( mobile != null)
			{
				if( dropped is NewSewingBasketKey )
            
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "My Specialty Leathers!!!", mobile.NetState );
         				return false;
         			}
                                if ( !NewSewingBasketKeyReceived ) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new TailorKey() );
					mobile.SendMessage( "Thank you for your help! Take care of this Tailor Key, you only get one." );
                                        acct.SetTag( "NewSewingBasketKeyReceived", "true" );

				
         		        }
				else //what to do if account has already been tagged
         			{
         				mobile.SendMessage("I have only gold for you, I gave you the Tailor Key last time.");
         				mobile.AddToBackpack( new Gold( 8500 ) );
         				dropped.Delete();
         			}
         		}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Why on earth would I want to have that?", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
