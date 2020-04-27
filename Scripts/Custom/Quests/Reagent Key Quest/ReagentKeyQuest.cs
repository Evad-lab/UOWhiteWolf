using System;
using System.Collections;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server;
using Server.Items;
using Server.Gumps;
using System.Collections.Generic;
using Server.Spells;
using Server.Accounting;

namespace Server.Mobiles
{
     	public class OldManMage : Mobile
	    {		

		[Constructable]
		public OldManMage()
		{
		Name = "Old Man Mage [?]";
			Body = 401;
            CantWalk = true;
            Blessed = true;
			Hue = 1751;

			Item Boots = new Boots();
			Boots.Hue = 1000;
      	    Boots.Name = "Non-Leather Boots";
			Boots.Movable = false;
			AddItem( Boots ); 

			Item FancyShirt = new FancyShirt();
			FancyShirt.Hue = 1000;
      	    FancyShirt.Name = "Shirt";
			FancyShirt.Movable = false;
			AddItem( FancyShirt ); 

			Item LongPants = new LongPants();
			LongPants.Hue = 1000;
      	    LongPants.Name = "Pants";
			LongPants.Movable = false;
			AddItem( LongPants ); 

			Item Cloak = new Cloak();
			Cloak.Hue = 1000;
      	    Cloak.Name = "Cloak";
			Cloak.Movable = false;
			AddItem( Cloak ); 

			AddItem( new LongHair( 254 ) );			
		}
		
		public OldManMage( Serial serial ) : base( serial )
		{
		}
            public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)  
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new AlEntry( from, this ) ); 
	        } 

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		
		}
		
		public class AlEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public AlEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( AlGump ) ) )
					{
						mobile.SendGump( new AlGump( mobile ));
						
					} 
				}
			}
		}
		
		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
			bool MassiveMandrakeReceived = Convert.ToBoolean( acct.GetTag("MassiveMandrakeReceived") );

			if ( mobile != null)
			{
				if( dropped is MassiveMandrake )
            
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Oh my stars, you have brought back my Mandrake!!!", mobile.NetState );
         				return false;
         			}
                                if ( !MassiveMandrakeReceived ) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new ReagentKey() );
					mobile.SendMessage( "Thank you for your help! Take good care of this, you only get one!" );
                                        acct.SetTag( "MassiveMandrakeReceived", "true" );

				
         		        }
				else //what to do if account has already been tagged
         			{
         				mobile.SendMessage("I have only gold for you, I gave you the Reagent Key last time.");
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