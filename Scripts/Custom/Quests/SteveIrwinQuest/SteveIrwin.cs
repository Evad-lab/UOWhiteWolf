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
	[CorpseName( "Steve Irwin's Corpse" )]
	public class SteveI : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public SteveI()
		{
			Name = "Steve Irwin";
                        
			Body = 0x190;
			CantWalk = true;
			Hue = 0x83F8;
			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.Shirt( 1436 ) );
			AddItem( new Server.Items.ShortPants( 1436 ) );
			AddItem( new Server.Items.WideBrimHat( 1436 ) );

            int hairHue = 1122;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



		public SteveI( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new SteveIrwinEntry( from, this ) ); 
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

		public class SteveIrwinEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public SteveIrwinEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( SteveIrwinGump ) ) )
					{
						mobile.SendGump( new SteveIrwinGump( mobile ));
						
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
				if( dropped is CrocEgg )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Strewth Mate.You Trying To Be Funny ?????", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
					mobile.AddToBackpack( new CrocodillPetStatue() );
					mobile.AddToBackpack( new Gold( 2500 ));
					mobile.SendGump( new SteveIrwinFinishGump());


				
					return true;
         		}
				else if ( dropped is CrocEgg )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "What The Hell Is This??? This Has To Be The Worse Bunch Of Players I Have Ever Seen !!!!", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
