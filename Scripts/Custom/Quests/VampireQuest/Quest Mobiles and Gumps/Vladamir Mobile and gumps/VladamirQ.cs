
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
using Server.Commands;

namespace Server.Mobiles
{
	[CorpseName( "Corpse Of Vladamir" )]
	public class Vladamir : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Vladamir()
		{
			Name = "Vladamir";
                        Title = "Collector of Uniques";
			Body = 400;
			CantWalk = true;
			Hue = 0;
			AddItem( new Server.Items.Cloak( 1250 ) );
			Item weapon = new Kryss();
				weapon.Movable = false;
				weapon.Hue = 2410;
			AddItem( weapon );
			Item shield = new ChaosShield();
				shield.Movable = false;
				shield.Hue = 2410;
			AddItem( shield );
			Item arms = new PlateArms();
				arms.Movable = false;
				arms.Hue = 2410;
			AddItem( arms );
			Item gloves = new PlateGloves();
				gloves.Movable = false;
				gloves.Hue = 2410;
			AddItem( gloves );
			Item chest = new PlateChest();
				chest.Movable = false;
				chest.Hue = 2410;
			AddItem( chest );
			Item legs = new PlateLegs();
				legs.Movable = false;
				legs.Hue = 2410;
			AddItem( legs );
			Item helm = new NorseHelm();
				helm.Movable = false;
				helm.Hue = 2410;
			AddItem( helm );
			Item gorget = new PlateGorget();
				gorget.Movable = false;
				gorget.Hue = 2410;
			AddItem( gorget );

                        int hairHue = 1055;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}

			public virtual int GetBootsHue()
			{
			return 2410;
			}

			public virtual int GetCloakHue()
			{
			return 1172;
			}

		public Vladamir( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new VladamirEntry( from, this ) ); 
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

		public class VladamirEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public VladamirEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( VampQuestGump ) ) )
					{
						mobile.SendGump( new VampQuestGump( mobile ));
						mobile.AddToBackpack( new VampKnife6() );
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
				if( dropped is BlueHeart )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampArms() );
					mobile.AddToBackpack( new VampKnife1() );
					mobile.SendGump( new VampQuestGump1(m) );

				
					return true;
         			}
				else if ( dropped is BlueHeart )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the heart I'm seeking.", mobile.NetState );
     				}
				if( dropped is SilverHeart )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampGloves() );
					mobile.AddToBackpack( new VampKnife2() );
					mobile.SendGump( new VampQuestGump2(m) );

				
					return true;
         			}
				else if ( dropped is SilverHeart)
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the heart I'm seeking.", mobile.NetState );
     				}
				if( dropped is BlackHeart1 )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampGorget() );
					mobile.AddToBackpack( new VampKnife3() );
					mobile.SendGump( new VampQuestGump3(m) );

				
					return true;
         			}
				else if ( dropped is BlackHeart1 )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the heart I'm seeking.", mobile.NetState );
     				}
				if( dropped is BloodHeart )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampLegs() );
					mobile.AddToBackpack( new VampKnife4() );
					mobile.SendGump( new VampQuestGump4(m) );

				
					return true;
         			}
				else if ( dropped is BloodHeart )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the heart I'm seeking.", mobile.NetState );
     				}
				if( dropped is GoldenHeart )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampHelm() );
					mobile.AddToBackpack( new VampKnife5() );
					mobile.SendGump( new VampQuestGump5(m) );

				
					return true;
         			}
				else if ( dropped is GoldenHeart )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         			else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the heart I'm seeking.", mobile.NetState );
     				}
				if( dropped is WhiteHeart )
         			{
         				if(dropped.Amount!=1)
         				{
         					return false;
         				}

					dropped.Delete(); 
					
					mobile.AddToBackpack( new VampChest() );
					mobile.AddToBackpack( new VampKnife6() );
					mobile.AddToBackpack( new Letter1() );
					mobile.SendGump( new VampQuestGump6(m) );
				

					return true;
         			}
				else if ( dropped is WhiteHeart )
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
