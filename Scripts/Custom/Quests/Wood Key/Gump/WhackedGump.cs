using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class WhackedGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "WhackedGump", AccessLevel.GameMaster, new CommandEventHandler( WhackedGump_OnCommand ) ); 
		}
		
		private static void WhackedGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new WhackedGump( e.Mobile ) );
		}

		public WhackedGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Wood Key Quest" );
//----------------------/----------------------------------------------/
			AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>I've managed to cut off my left arm, I need help gathering wood. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Whacked it clear off! *holds out healed stump of remaining arm*<BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you bring me some rare logs, I will give you something in return for your efforts.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>All the logs are held by deadly Treefellows, they wander the lands in Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The first is the Ebony Treefellow.  Find him in the wilds east of the Destard Dungeon.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next, is the Bamboo Treefellow. You'll find him wandering east of the Cove Cemetary<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The third, is the PurpleHeart Treefellow.  I've heard of him wandering around Yew.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next Treefellow, is the Redwood.  He's been seen off to the west of Skara Brae on the tiny isle there.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fifth and final Treefellow, is the Petrified. He's a mean son of a pickled hare.  He wanders around the crossroads, west of Britain.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Go and kill these Treefellows and gather their fresh woods into this Rotten Log, return to me for your reward.<BR><BR>" +

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
