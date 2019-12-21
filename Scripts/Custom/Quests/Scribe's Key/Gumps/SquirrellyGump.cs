using System; 
using Server;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
	public class SquirrellyGump : Gump 
	{ 
		public static void Initialize() 
		{ 
			CommandSystem.Register( "SquirrellyGump", AccessLevel.GameMaster, new CommandEventHandler( SquirrellyGump_OnCommand ) ); 
		}
		
		private static void SquirrellyGump_OnCommand( CommandEventArgs e ) 
		{
			e.Mobile.SendGump( new SquirrellyGump( e.Mobile ) );
		}

		public SquirrellyGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Scribes Key Quest" );
//----------------------/----------------------------------------------/
			AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>I need your help warrior. I am a scribe, as you might have noticed. I cannot fight things like you can. <BR><BR>" +
"<BASEFONT COLOR=YELLOW>So please, can you help me? You look so strong and brave, I could write a book about you if you die!<BR><BR>" +
"<BASEFONT COLOR=YELLOW>I need several items to construct a book, a key really. If I have enough materials I might share a book with you.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>All the items I need are held by other scribes, in Felucca.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The first scribe is in the Yew Cemetary, he holds the Well Used Scribe's Pen.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The second scribe, is in the Jhelom Cemetary, he has a scroll of unlimited uses.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next scribe, is in Magincia near the old moongate, he should possess the wonderous rune.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fourth scribe, is in the Britain Cemetary, he has the minor site scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The fifth scribe, is in outside of Cove near the orc fort, he has the minor strength scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next scribe, is in Minoc just to the south, he has the minor fireball scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The seventh scribe, is in northern Skara Brae, he has the minor lightning scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The eighth scribe, is in Ocollo, he has the smaller blade spirits scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The next scribe, is in near Papua, he has the minor explosion scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The tenth scribe, is in the Nujel'm Cemetary, he has the small meteor swarm scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The last scribe, is outside the west Trinsic gate, he has the almost not dead scroll.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Bring to me all the above items, I will combine them and if I have enough left over, you will get a reward (besides this bag of gold).<BR><BR>" +


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
