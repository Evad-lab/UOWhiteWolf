using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class MarmaladeTheTailorGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "MarmaladeTheTailorGump", AccessLevel.GameMaster, new CommandEventHandler( MarmaladeTheTailorGump_OnCommand ) ); 
		}
		
		private static void MarmaladeTheTailorGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new MarmaladeTheTailorGump( e.Mobile ) );
		}

		public MarmaladeTheTailorGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Tailor Key Quest" );
//----------------------/----------------------------------------------/
			AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>A bunch of Centaur's have taken my specialty leathers, get them back and I will reward you with the Tailor's Key! <BR><BR>" +
"<BASEFONT COLOR=YELLOW>You will need to use this Old Sewing Basket to store the leathers once you have gathered them all. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Double clicking the basket, will transform it into the New Sewing Basket, and store all the leathers for you. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>The first Centaur can be found the Broken Mountain in Malas, out behind the Inn. He should just have my plain old Specialty Leather.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Next you will want to travel to Felucca.  Find the Honor Shrine and go north.  You'll find the centaur who holds the Specialty Spined Leather.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Go to Makato-Jima in Tokuno. Inside 'The Waste' you'll find the Specialty Horned Leather. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Travel to the Field of Echos in Homare-Jima.  Therein you will find my Specialty Barbed Leather.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Inside the Dungeon Deceit, Trammel you will find the Specialty Synthetic Leather.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>On the fringes of Yew, Felucca you'll find the Specialy Shadow Leather held by the Centaur there. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Next you will find the Specialty Daemonic Leather near the bottom of the Hythloth Dungeon in Trammel.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>You will find the Specialty Frosted Leather somewhere in Malas beside an Orc Fort.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The final piece, you will find far south of Trinsic, Felucca.  You're looking for the Specialty Ethereal Leather there. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Return to me with the filled New Sewing Basket, and I will give you your reward.<BR><BR>" +
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
