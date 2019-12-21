using System;
using Server;
using Server.Misc;
using Server.Mobiles;
using Server.Network;
using Server.Prompts;
using Server.Targeting;
using Server.Items;
using Server.Gumps;

namespace Server.Items
{
	public class ItemIDDeed : Item
	{

		[Constructable]
		public ItemIDDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
			Hue = 1161;
			Name = "Item ID Deed";
		}

		public ItemIDDeed( Serial serial ) : base( serial )
		{
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

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			else
			{
				from.CloseGump( typeof( ItemIDDeedGump));
				from.SendGump( new ItemIDDeedGump() );
			}
		}
	}
}

namespace Server.Gumps
{
	public class ItemIDDeedGump : Gump
	{
		public ItemIDDeedGump()
			: base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(212, 21, 436, 576, 9270);
			this.AddBlackAlpha(216, 25, 428, 568);
			this.AddLabel(460, 38, 1160, "UO Union");
			this.AddCheck(232, 66, 10810, 10830, false,50);//Kasa
			this.AddCheck(454, 202, 10810, 10830, false,71);// F Skirt
			this.AddCheck(454, 229, 10810, 10830, false,72);// F Armor
			this.AddCheck(454, 255, 10810, 10830, false,73);//Necklace
			this.AddCheck(454, 282, 10810, 10830, false,74);//Earrings
			this.AddCheck(454, 309, 10810, 10830, false,75);//Rings
			this.AddCheck(454, 67, 10810, 10830, false,66);//Half Apron
			this.AddCheck(454, 417, 10810, 10830, false,79);//Bone Arms
			this.AddCheck(232, 470, 10810, 10830, false,65);// Jin Baori
			this.AddCheck(454, 175, 10810, 10830, false,70);//Shirt
			this.AddCheck(454, 363, 10810, 10830, false,77);//SpellBook
			this.AddCheck(454, 336, 10810, 10830, false,76);//Bracelet
			this.AddCheck(454, 390, 10810, 10830, false,78);//Bone Hands
			this.AddCheck(454, 148, 10810, 10830, false,69);//Doublet
			this.AddCheck(454, 121, 10810, 10830, false,68);//Skirt
			this.AddCheck(454, 94, 10810, 10830, false,67);//Body Sash
			this.AddCheck(232, 444, 10810, 10830, false,64);//Waraji and Tabi
			this.AddCheck(232, 417, 10810, 10830, false,63);//Boots
			this.AddCheck(232, 390, 10810, 10830, false,62);//Sandals
			this.AddCheck(232, 363, 10810, 10830, false,61);//Bone helm
			this.AddCheck(232, 336, 10810, 10830, false,60);//Tricorne
			this.AddCheck(232, 309, 10810, 10830, false,59);//Feathered
			this.AddCheck(232, 283, 10810, 10830, false,58);//Bonnet
			this.AddCheck(232, 256, 10810, 10830, false,57);//Straw
			this.AddCheck(232, 229, 10810, 10830, false,56);//Tall Straw
			this.AddCheck(232, 202, 10810, 10830, false,55);//Deer Mask
			this.AddCheck(232, 175, 10810, 10830, false,54);//Tribal
			this.AddCheck(232, 148, 10810, 10830, false,53);//Bandana
			this.AddCheck(232, 121, 10810, 10830, false,52);//Jester
			this.AddCheck(232, 94, 10810, 10830, false,51);//Floppy
			this.AddCheck(454, 495, 10810, 10830, false,82);//Lantern
			this.AddCheck(454, 522, 10810, 10830, false,83);//Candle
			this.AddCheck(454, 549, 10810, 10830, false,84);//Torch
			this.AddCheck(454, 469, 10810, 10830, false,81);//Bone Chest
			this.AddCheck(454, 443, 10810, 10830, false,80);//Bone Legs
			this.AddButton(271, 539, 10800, 10820, 1, GumpButtonType.Reply, 0);
			this.AddLabel(304, 516, 1160, @"START");
			this.AddLabel(268, 70, 27, @"Kasa");
			this.AddLabel(268, 99, 27, @"Floppy Hat");
			this.AddLabel(268, 154, 27, @"Bandana");
			this.AddLabel(268, 126, 27, @"Jester Hat");
			this.AddLabel(268, 181, 27, @"Tribal Mask");
			this.AddLabel(268, 208, 27, @"Deer Mask");
			this.AddLabel(268, 234, 27, @"Mexico Hat");
			this.AddLabel(268, 263, 27, @"Straw Hat");
			this.AddLabel(268, 289, 27, @"Bonnet");
			this.AddLabel(268, 315, 27, @"Feathered Hat");
			this.AddLabel(269, 342, 27, @"Tricorne Hat");
			this.AddLabel(268, 368, 27, @"Bone Helm");
			this.AddLabel(268, 394, 27, @"Sandals");
			this.AddLabel(268, 421, 27, @"Boots");
			this.AddLabel(268, 448, 27, @"Waraji Tabi");
			this.AddLabel(268, 475, 27, @"Jin-Baori");
			this.AddLabel(491, 72, 27, @"Half Apron");
			this.AddLabel(491, 100, 27, @"Body Sash");
			this.AddLabel(491, 127, 27, @"Skirt");
			this.AddLabel(492, 181, 27, @"Shirt");
			this.AddLabel(492, 154, 27, @"Doublet");
			this.AddLabel(492, 207, 27, @"F-Skirt");
			this.AddLabel(492, 233, 27, @"F-Armor");
			this.AddLabel(492, 258, 27, @"Necklace");
			this.AddLabel(492, 285, 27, @"Earrings");
			this.AddLabel(492, 313, 27, @"Ring");
			this.AddLabel(492, 339, 27, @"Bracelet");
			this.AddLabel(492, 367, 27, @"Spell Book");
			this.AddLabel(492, 394, 27, @"Bone Hands");
			this.AddLabel(492, 473, 27, @"Bone Chest");
			this.AddLabel(492, 447, 27, @"Bone Legs");
			this.AddLabel(492, 501, 27, @"Lantern");
			this.AddLabel(492, 527, 27, @"Candle");
			this.AddLabel(492, 553, 27, @"Torch");
			this.AddLabel(492, 420, 27, @"Bone Arms");
			this.AddLabel(260, 38, 37, ServerList.ServerName.ToString());
			this.AddItem(387, 71, 10136);
			this.AddItem(388, 96, 5907);
			this.AddItem(386, 126, 5916);
			this.AddItem(388, 155, 5439);
			this.AddItem(382, 174, 5450);
			this.AddItem(386, 193, 5447);
			this.AddItem(388, 229, 5910);
			this.AddItem(389, 259, 5911);
			this.AddItem(389, 291, 5913);
			this.AddItem(391, 314, 5914);
			this.AddItem(388, 341, 5915);
			this.AddItem(393, 365, 5201);
			this.AddItem(390, 387, 5901);
			this.AddItem(389, 411, 5899);
			this.AddItem(393, 443, 10134);
			this.AddItem(386, 468, 10145);
			this.AddItem(579, 67, 5435);
			this.AddItem(570, 98, 5441);
			this.AddItem(564, 118, 5398);
			this.AddItem(551, 151, 8059);
			this.AddItem(566, 178, 5399);
			this.AddItem(570, 204, 7176);
			this.AddItem(572, 230, 7174);
			this.AddItem(572, 262, 4232);
			this.AddItem(571, 289, 4231);
			this.AddItem(567, 316, 4234);
			this.AddItem(574, 344, 4230);
			this.AddItem(577, 364, 3834);
			this.AddItem(572, 393, 5200);
			this.AddItem(576, 421, 5198);
			this.AddItem(576, 441, 5202);
			this.AddItem(568, 459, 5199);
			this.AddItem(563, 498, 2581);
			this.AddItem(567, 520, 2575);
			this.AddItem(575, 536, 2578);
			this.AddImage(162, 1, 10400);
			this.AddImage(162, 200, 10401);
			this.AddImage(162, 421, 10402);
		}
		
		public void AddBlackAlpha( int x, int y, int width, int height )
		{
			AddImageTiled( x, y, width, height, 9354 );
			//AddAlphaRegion( x, y, width, height );
		}
		
		public enum Buttons
		{
		}
		
		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile m = state.Mobile;
			int m_ItemID;
			
			switch( info.ButtonID )
			{
				case 1:
				{
					if( info.IsSwitched ( 50 )  )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 10136;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 51 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5907;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}

					else if ( info.IsSwitched ( 52 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5916;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 53 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5440;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 54 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5449;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 55 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5447;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 56 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5910;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}

					else if ( info.IsSwitched ( 57 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5911;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 58 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5913;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 59 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5914;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}

					else if ( info.IsSwitched ( 60 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5915;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 61 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5201;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 62 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5901;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 63 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5899;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 64 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 10134;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}

					else if ( info.IsSwitched ( 65 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 10145;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 66 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5435;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 67 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5441;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 68 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5398;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 69 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 8059;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 70 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5399;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 71 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 7176;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 72 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 7174;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 73 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 4232;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 74 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 4231;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 75 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 4234;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 76 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 4230;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 77 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 3834;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 78 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5200;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 79 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5198;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 80 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5202;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 81 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 5199;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 82 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 2594;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 83 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 2575;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}
					
					else if ( info.IsSwitched ( 84 ) )
					{
						if( info.Switches.Length == 1 )
						{
							m_ItemID = 2578;
							m.Target = new ItemIDTarget( m_ItemID );
						}
						else 
						{
							m.SendMessage( 38,"You cant do this");
						}
					}

						
					
					else
					{
						m.SendMessage( 38,"You cant do this");
					}
					break;
				}
				
				case 0:
				{
					m.SendMessage( 38,"Cancelled" ); 
					break;
				}
			}
		}
		
		public class ItemIDTarget : Target
		{
			int m_ItemID;
			
			public ItemIDTarget( int itemid ) : base( -1, true, TargetFlags.None )
			{
				m_ItemID = itemid;
			}	
		
			protected override void OnTarget( Mobile from, object target ) // Override the protected OnTarget() for our feature
			{
				Item a = from.Backpack.FindItemByType( typeof( ItemIDDeed ) );
			
				if( target is BaseJewel || target is BaseArmor || target is BaseClothing ||target is BaseShield  )
				{
					if( a != null )
					{
						Item item = (Item)target;
					
							if( item.RootParent == from ) // Make sure its in their pack or they are wearing it
							{
								item.ItemID = m_ItemID;
								a.Delete();
								from.SendMessage( "You have changed the item id" ); 
							}
						
							else
							{
								from.SendMessage( 38,"It should be in your backpack");
							}
					}
					
					else
					{
						from.SendMessage( 38," You dont have a item id deed in your backpack ");
						from.CloseGump( typeof (ItemIDDeedGump));
					}
				}
			
				else
				{
					from.SendMessage( 38,"You can change only armors, jewellerys and clothings Item ID !");
				}
			}
		}
	}	
}
