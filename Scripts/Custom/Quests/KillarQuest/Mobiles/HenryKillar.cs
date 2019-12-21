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

namespace Server.Mobiles
{
	[CorpseName( "HenryKillar corpse" )]
	public class HenryKillar : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public HenryKillar()
		{
			Name = "Henry Killar";
                        Title = "Second Eldest Killar Brother";
			Body = 400;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();
			AddItem( new Server.Items.Boots( GetBootsHue() ) );
			AddItem( new Robe(1161)); 
			AddItem( new Server.Items.PaladinSword() );
                        int hairHue = 1153;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}

			public virtual int GetBootsHue()
			{
			return 1157;
		}

		public HenryKillar( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new HenryKillarEntry( from, this ) ); 
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

		public class HenryKillarEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public HenryKillarEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( HenryGump ) ) )
					{
						mobile.SendGump( new HenryGump( mobile ));
//
						
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
				if( dropped is HeadOfReddix )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Unite My Family's Artifacts!", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
										
					mobile.AddToBackpack( new BraceletOfKillar() );
					mobile.SendMessage( "Unite My Family's Artifacts!" );

				
					return true;
         		}
				else if ( dropped is HeadOfReddix )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
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
