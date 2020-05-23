using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class GaryGraniteGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "GaryGraniteGump", AccessLevel.GameMaster, new CommandEventHandler( GaryGraniteGump_OnCommand ) ); 
		}
		
		private static void GaryGraniteGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new GaryGraniteGump( e.Mobile ) );
		}

		public GaryGraniteGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Granite Key Quest" );
//----------------------/----------------------------------------------/
			AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>I have lost my favorite Granite pieces, find them, and get them back for me and I will reward you with the Granite Storage Key! <BR><BR>" +
"<BASEFONT COLOR=YELLOW>You will need to use this Terrible Granite Key to store the Missing Granite pieces once you have gathered them all. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>By double clicking the key, will transform it into the Improved Granite Key, and it store all the granites for you. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>You must search for Granite Elementals, they were drawn to my lost granites and have taken them for themselves.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The first creature is located in the Fire Dungeon in Trammel. He's down on the 2nd level.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>For the Ice piece, you'll need to go to the Ice Dungeon in Trammel. The besty has it locked away inside the Rat area. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Next, travel to the City of Trinsic, Felucca. North East of the city you will fid the Toxic piece.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Near the Grimswald Ruins in Malas, you will find the captivating specimen of Electrum.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The final piece, the glorious Platinum specimen, will be found on Ice Island in Felucca. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Return to me with the Improved Granite Key, and I will give you your reward.<BR><BR>" +
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
