//Scripted By James4245
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
    [CorpseName("Gandalf's Corpse")]
	public class Gandalf : Mobile
	{
        public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Gandalf()
		{
			Name = "Gandalf";            
			Body = 0x190;
			CantWalk = true;
			Hue = 0;
			AddItem( new Server.Items.Robe( 1153 ) );
			AddItem( new Server.Items.ShortPants( 1153 ) );
					
            int hairHue = 1157;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}

        public Gandalf(Serial serial) : base(serial)
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list );
                    list.Add( new GandalfEntry( from, this ) ); 
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

		public class GandalfEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;

            public GandalfEntry(Mobile from, Mobile giver) : base(6146, 3)
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
                    if (!mobile.HasGump( typeof(GandalfQuestGump ) ) )
					{
                        mobile.SendGump( new GandalfQuestGump ( mobile ) );
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
                if ( dropped is TheHeadOfSauron )
			{
				if( dropped.Amount!=1)
				{
                    this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "You Have Defeated The Dreaded Dark Wizard Sauron", mobile.NetState);
					return false;
				}
				
					dropped.Delete();
                    mobile.SendGump( new GandalfQuestGump2 ( m ) );
					
 			if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
			switch ( Utility.Random( 1 ))  
			{

                case 0: mobile.AddToBackpack( new Glamdring ()); break;
					
			}					
				
					return true;
         		}
                else if ( dropped is TheHeadOfSauron )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thats Not The Head Of The Dreaded Dark Wizard Sauron, You Don't Want To Play Games With Me", mobile.NetState );
     			}
			}
			return false;
		}
		}
}
	

