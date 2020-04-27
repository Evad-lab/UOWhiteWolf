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
	[CorpseName( "a corpse of a squirrell" )]
	public class Squirrelly : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Squirrelly()
		{
			Name = "Squirrelly";
                        Title = "the Scribe Guy [?]";
			Body = 0x190;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();

			Utility.AssignRandomHair( this );

			AddItem( new Server.Items.Robe( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.LongPants( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.Boots( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.HalfApron( Utility.RandomNeutralHue() ) );

			Container pack = new Backpack();
			pack.DropItem( new Gold( 250, 300 ) );
			pack.Movable = false;
			AddItem( pack );

		}

		public Squirrelly( Serial serial ) 
		        : base( serial )
		{
		}
		
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new SquirrellyEntry( from, this ) ); 
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

		public class SquirrellyEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public SquirrellyEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( SquirrellyGump ) ) )
					{
						mobile.SendGump( new SquirrellyGump( mobile ));
						mobile.AddToBackpack( new YeOldScribesKey() );
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
			bool TheNewScribesKeyReceived = Convert.ToBoolean( acct.GetTag("TheNewScribesKeyReceived") );

			if ( mobile != null)
			{
				if( dropped is TheNewScribesKey )
            
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thanks for your help!!!", mobile.NetState );
         				return false;
         			}
                                if ( !TheNewScribesKeyReceived ) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new ScribesKey() );
					mobile.SendMessage( "Here's a Scribe's Key, not quite as good as my New Scribe's Key, but almost! You only get one Key!" );
                                        acct.SetTag( "TheNewScribesKeyReceived", "true" );

				
         		        }
				else //what to do if account has already been tagged
         			{
         				mobile.SendMessage("I have only gold for you, I gave you the Scribe Key last time.");
         				mobile.AddToBackpack( new Gold( 5500 ) );
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
