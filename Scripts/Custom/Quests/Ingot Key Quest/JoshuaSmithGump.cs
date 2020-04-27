using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class JoshuaSmithGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "JoshuaSmithGump", AccessLevel.GameMaster, new CommandEventHandler( JoshuaSmithGump_OnCommand ) ); 
		}
		
		private static void JoshuaSmithGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new JoshuaSmithGump( e.Mobile ) );
		}

		public JoshuaSmithGump( Mobile owner ) : base( 50,50 ) 
		{
//----------------------------------------------------------------------------------------------------

				AddPage( 0 );
			AddImageTiled(  54, 33, 369, 400, 2624 );
			AddAlphaRegion( 54, 33, 369, 400 );
			AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------

			AddImage( 97, 49, 9005 );
			AddImageTiled( 58, 39, 29, 390, 10460 );
			AddImageTiled( 412, 37, 31, 389, 10460 );
			AddLabel( 140, 60, 0x34, "Forgiven Quest" );
//----------------------/----------------------------------------------/
			AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>All my specialty ores have been stolen!  You might ask who would do such a thing? <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Jealousy! That's who!  Jealousy made other smiths steal my beautiful ores, and turned the thieves into monsters!<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Bring me back all of my missing ores and I will reward you with an Ingot Storage Key.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>You will only receive one Key, do not give, sell or lose the one I give you.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The first smith can be found in the dungeon Shame, on the first level, in Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>His name is Marcus. Please find my Shiny Iron Ingot. Be careful brave warrior.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next Shiny Ingot to find is the Dull Copper Ingot.  This one is held by Brady, near the Shrine of Compassion in Ilshenar.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The third Shiny Ingot to find is the Shadow Iron Ingot.  This one is held by Phil, inside the Blood Dungeon, Ilshenar.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fourth Shiny Ingot to find is the Copper Ingot.  This one is held by Neily, inside the Despise Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fifth Shiny Ingot to find is the Bronze Ingot.  This one is held by Ferra, inside the Hythloth Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The sixth Shiny Ingot to find is the Gold Ingot.  This one is held by Emma, inside the Wrong Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The seventh Shiny Ingot to find is the Agapite Ingot.  This one is held by Jake, inside the Covetous Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The eighth Shiny Ingot to find is the Verite Ingot.  This one is held by Montero, inside the Destard Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The ninth Shiny Ingot to find is the Valorite Ingot.  This one is held by the Sandman, inside Terathan Keep, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The tenth Shiny Ingot to find is the Blaze Ingot.  This one is held by Mentor, inside the Fire Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The eleventh Shiny Ingot to find is the Ice Ingot.  This one is held by the Big Razi, inside the Ice Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The twelveth Shiny Ingot to find is the Toxic Ingot.  This one is held by Cinder, inside the Fire Dungeon, Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The thirteenth Shiny Ingot to find is the Electrum Ingot.  This one is held by Jax, near the Honor Shrine, Ilshenar.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fourtheenth Shiny Ingot to find is the Platinum Ingot.  This one is held by Fabio, inside the Deceit Dungeon, Trammel.<BR><BR>" +
"</BODY>", false, true);
//----------------------/----------------------------------------------/
			AddImage( 430, 9, 10441);
			AddImageTiled( 40, 38, 17, 391, 9263 );
			AddImage( 6, 25, 10421 );
			AddImage( 34, 12, 10420 );
			AddImageTiled( 94, 25, 342, 15, 10304 );
			AddImageTiled( 40, 427, 415, 16, 10304 );
			AddImage( -10, 314, 10402 );
			AddImage( 56, 150, 10411 );
			AddImage( 155, 120, 2103 );
			AddImage( 136, 84, 96 );
			AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 );
//----------------------/----------------------------------------------/ 
		}
		public override void OnResponse( NetState state, RelayInfo info )
		{ 
			Mobile from = state.Mobile; 

			switch ( info.ButtonID ) 
			{ 
				case 0:
				{
					 break; 
				}
			}
		}
	}
}
