
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
	[CorpseName( "Meiko's Corpse" )]
	public class Meiko : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Meiko()
		{
			Name = "Meiko";
            Title = "the Vampire Slayer";
			Body = 0x190;
			CantWalk = true;
			Hue = 0x83F8;
		
			Item weapon = new RepeatingCrossbow();
				weapon.Movable = false;
				weapon.Hue = 37;
			AddItem( weapon );
			Item arms = new PlateArms();
				arms.Movable = false;
				arms.Hue = 1150;
			AddItem( arms );
			Item gloves = new PlateGloves();
				gloves.Movable = false;
				gloves.Hue = 1150;
			AddItem( gloves );
			Item chest = new PlateChest();
				chest.Movable = false;
				chest.Hue = 1150;
			AddItem( chest );
			Item legs = new PlateLegs();
				legs.Movable = false;
				legs.Hue = 1150;
			AddItem( legs );
			Item gorget = new PlateGorget();
				gorget.Movable = false;
				gorget.Hue = 1150;
			AddItem( gorget );
			Item VampireRobe = new VampireRobe();
				VampireRobe.Movable = false;
				VampireRobe.Hue = 37;
			AddItem( VampireRobe );

            int hairHue = 1150;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			int VandykeHue = 1150;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new Vandyke( VandykeHue ) ); break;
			} 
			
			Blessed = true;
			
		}



		public Meiko( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
		{ 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new MeikoEntry( from, this ) ); 
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

		public class MeikoEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
				
			public MeikoEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( VampQuestGump11 ) ) )
					{
						Item a = m_Mobile.Backpack.FindItemByType( typeof(EverClear) );
						if ( a !=null )
						{
							a.Delete();
							mobile.SendGump( new VampQuestGump11( mobile ));
							mobile.AddToBackpack( new TubOfButter() );
						}
						else
						{
							m_Mobile.SendMessage( "Get out before you end up dead!" );
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
				if( dropped is CrestedRing )
				{
					if( dropped.Amount!=1)
					{
						this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "You Have gotten the Crested Ring well done", mobile.NetState );
						return false;
					}
				
					dropped.Delete();
					mobile.SendGump( new VampQuestGump12(m) );
					
 					if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
					switch ( Utility.Random( 1 ))  
					{ 
		
						case 0: mobile.AddToBackpack( new VampRing() ); break;
					
					
					}					
					
					return true;
         			}
				else if ( dropped is CrestedRing )
				{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         				return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thats Not The Crested Ring", mobile.NetState );
     				}
			}
			return false;
		}
	}
}

	

