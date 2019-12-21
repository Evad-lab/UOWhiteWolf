// Scripted by Karmageddon
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
using Server.Engines.Quests;

namespace Server.Mobiles
{
	[CorpseName( "Dragon Smith Corpse" )]
	public class DragonSmith : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
                
		[Constructable]
		public DragonSmith()
		{
			Name = NameList.RandomName( "male" );
                        Title = "the Dragon Smith";
			Body = 0x190;
			CantWalk = true;
			Hue = 0x83F8;
                        int hairHue = 1741;
                        
                        PlateArms arms = new PlateArms();
			arms.LootType = LootType.Newbied;
			arms.Hue = 1157;
			AddItem( arms );

			PlateGloves gloves = new PlateGloves();
			gloves.LootType = LootType.Newbied;
			gloves.Hue = 1157;
			AddItem( gloves );

			PlateLegs legs = new PlateLegs();
			legs.LootType = LootType.Newbied;
			legs.Hue = 1157;
			AddItem( legs );

			PlateGorget neck = new PlateGorget();
			neck.LootType = LootType.Newbied;
			neck.Hue = 1157;
			AddItem( neck );

			PlateChest chest = new PlateChest();
			chest.LootType = LootType.Newbied;
			chest.Hue = 1157;
			AddItem( chest );
                        
                        SmithHammer weapon = new SmithHammer();

			weapon.Name = "Dragon Smithing Hammer";
			weapon.Hue = 1157;
			weapon.Movable = false;
			
			EquipItem( weapon );

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
		}
		public DragonSmith( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new DragonSmithEntry( from, this ) ); 
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

		public class DragonSmithEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public DragonSmithEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( DHQuestGump ) ) )
					{
						mobile.SendGump( new DHQuestGump( mobile ));
						mobile.AddToBackpack( new DHQuestBook() );
						
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
				if( dropped is DragonHeart )
         			{
         			Container pack = from.Backpack;
	
				if ( pack != null && pack.ConsumeTotal( typeof( DragonOre ), 1 ) )
				{
					if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
					switch ( Utility.Random( 9 ))  
					{ 
		
							case 0: mobile.AddToBackpack( new ArmsofDragon() ); break;
							case 1: mobile.AddToBackpack( new DragonBlade() ); break;
							case 2: mobile.AddToBackpack( new GlovesofDragon() ); break;
							case 3: mobile.AddToBackpack( new HelmetofDragon() ); break;
							case 4: mobile.AddToBackpack( new LeggingsofDragon() ); break;
							case 5: mobile.AddToBackpack( new DragonNeck() ); break;
							case 6: mobile.AddToBackpack( new DragonShield() ); break;
							case 7: mobile.AddToBackpack( new TunicofDragon() ); break;
							case 8: mobile.AddToBackpack( new TunicofDragonF() ); break;
					
					}
				
							return true;
				}
				else
				{
					from.SendMessage(0x22,"You also need a Dragon Ore before you recieve a piece of armor.");
			
				}				
					return false;
         			}
				else if ( dropped is DragonOre)
				{
					Container pack = from.Backpack;
					
					if ( pack != null && pack.ConsumeTotal( typeof( DragonHeart ), 1 ) )
					{
						if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
						switch ( Utility.Random( 9 ))  
						{ 
		
							case 0: mobile.AddToBackpack( new ArmsofDragon() ); break;
							case 1: mobile.AddToBackpack( new DragonBlade() ); break;
							case 2: mobile.AddToBackpack( new GlovesofDragon() ); break;
							case 3: mobile.AddToBackpack( new HelmetofDragon() ); break;
							case 4: mobile.AddToBackpack( new LeggingsofDragon() ); break;
							case 5: mobile.AddToBackpack( new DragonNeck() ); break;
							case 6: mobile.AddToBackpack( new DragonShield() ); break;
							case 7: mobile.AddToBackpack( new TunicofDragon() ); break;
							case 8: mobile.AddToBackpack( new TunicofDragonF() ); break;
					
						}
				
							return true;
					}
					else
					{
						from.SendMessage(0x22,"You also need a Dragon Heart before you recieve a piece of armor.");
			
					}				
						return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need of this!", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
