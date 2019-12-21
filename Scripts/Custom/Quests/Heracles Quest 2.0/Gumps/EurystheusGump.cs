using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class EurystheusGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "EurystheusGump", AccessLevel.GameMaster, new CommandEventHandler( EurystheusGump_OnCommand ) ); 
		}
		
		private static void EurystheusGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new EurystheusGump( e.Mobile ) );
		}

		public EurystheusGump( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW>My sibling, you have come to me asking<BR>" +
"<BASEFONT COLOR=YELLOW>for forgiveness. I can not forgive you<BR>" +
"<BASEFONT COLOR=YELLOW>unless you complete some tasks for me.<BR>" +
"<BASEFONT COLOR=YELLOW>The tasks are difficult. You will have<BR>" +
"<BASEFONT COLOR=YELLOW>to be strong and smart. You will use<BR>" +
"<BASEFONT COLOR=YELLOW>your brain and your muscles alike.<BR>" +
"<BASEFONT COLOR=YELLOW>Use the gate beside me.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>First off, You will need to find the <BR>" +
"<BASEFONT COLOR=YELLOW>Nemean Lion and slay him. Collect his<BR>" +
"<BASEFONT COLOR=YELLOW>tooth.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Second, You will need to slay the Lerna<BR>" +
"<BASEFONT COLOR=YELLOW>Hydra. Collect the Scale.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Third, Slay the Arcadia Stag and bring<BR>" +
"<BASEFONT COLOR=YELLOW>me his antler.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Fourth, you must kill the Erymanthus <BR>" +
"<BASEFONT COLOR=YELLOW>Boar and collect some ham. <BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Fifth, you must clean the dungeon <BR>" +
"<BASEFONT COLOR=YELLOW>and collect some dung.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Sixth, you must kill the man-eating <BR>" +
"<BASEFONT COLOR=YELLOW>Stymphalian Birds and collect a <BR>" +
"<BASEFONT COLOR=YELLOW>feather.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Seventh, you must slay the mad bull<BR>" +
"<BASEFONT COLOR=YELLOW>that terrorizes the townspeople in the<BR>" +
"<BASEFONT COLOR=YELLOW>nearby town. Collect a horn.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Eighth, you must kill a man-eating <BR>" +
"<BASEFONT COLOR=YELLOW>Bistones Mare and collect its tail.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Ninth, you must kill Hippolyte, the<BR>" +
"<BASEFONT COLOR=YELLOW>amazon queen and take her girdle.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Tenth, You must slay the protector <BR>" +
"<BASEFONT COLOR=YELLOW>Geryon and his cow. Get the Geryon <BR>" +
"<BASEFONT COLOR=YELLOW>Cows Hide.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Eleventh, Kill Hesperides and get the <BR>" +
"<BASEFONT COLOR=YELLOW>collect the golden apple that she <BR>" +
"<BASEFONT COLOR=YELLOW>protects.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>The last and final task is to get the<BR>" +
"<BASEFONT COLOR=YELLOW>bone from Cerberus. He loves to chew<BR>" +
"<BASEFONT COLOR=YELLOW>on this bone so it wont be easy. <BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>If you finish these tasks, you will be<BR>" +
"<BASEFONT COLOR=YELLOW>forgiven. <BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Collect all Items and <BR>" +
"<BASEFONT COLOR=YELLOW>Combine them into the chest.<BR>" +
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
