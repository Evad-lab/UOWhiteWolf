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
	[CorpseName( "a Legendary Smith's corpse" )]
	public class JoshuaSmith : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public JoshuaSmith()
		{
			Name = "Joshua";
                        Title = "the Legendary Blacksmith [?]";
			Body = 0x190;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();

			Utility.AssignRandomHair( this );

			AddItem( new Server.Items.FancyShirt( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.LongPants( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.Boots( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.SkullCap( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.FullApron( Utility.RandomNeutralHue() ) );

			Container pack = new Backpack();
			pack.DropItem( new Gold( 250, 300 ) );
			pack.Movable = false;
			AddItem( pack );

		}

		public JoshuaSmith( Serial serial ) 
		        : base( serial )
		{
		}
		
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new JoshuaSmithEntry( from, this ) ); 
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

		public class JoshuaSmithEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public JoshuaSmithEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( JoshuaSmithGump ) ) )
					{
						mobile.SendGump( new JoshuaSmithGump( mobile ));
						mobile.AddToBackpack( new AncientIngotKey() );
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
			bool RestoredIngotKeyReceived = Convert.ToBoolean( acct.GetTag("RestoredIngotReceived") );

			if ( mobile != null)
			{
				if( dropped is RestoredIngotKey )
            
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "My Specialty Ores!!!", mobile.NetState );
         				return false;
         			}
                                if ( !RestoredIngotKeyReceived ) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new IngotKey() );
					mobile.SendMessage( "Thank you for your help! Take good care of this, you only get one!" );
                                        acct.SetTag( "RestoredIngotKeyReceived", "true" );

				
         		        }
				else //what to do if account has already been tagged
         			{
         				mobile.SendMessage("I have only gold for you, I gave you the Ingot Key last time.");
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
