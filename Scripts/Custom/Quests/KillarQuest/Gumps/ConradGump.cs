using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class ConradGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "ConradGump", AccessLevel.GameMaster, new CommandEventHandler( ConradGump_OnCommand ) ); 
      } 

      private static void ConradGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new ConradGump( e.Mobile ) ); 
      } 

      public ConradGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Message for Henry Killar" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW>Conrad looks up at you wildly...<BR><BR>So you have heard of me have you? I am the Eldest of the Killar Brothers.<BR>" +
"<BASEFONT COLOR=YELLOW>My brothers and I have journeyed for many years...<BR><BR>But alas, I have lost them in battle.  My good traveler, will you help re-unite us?<BR>" +
"<BASEFONT COLOR=YELLOW>My brothers carry our family's greatest possessions, bestowed on us by our ancestors...<BR><BR>Individually, these items are RARE and powerfull!<BR>" +
"<BASEFONT COLOR=YELLOW>But if thou art honerable enough to bring them before me, I shall bestow you with our Greastet possession!!<BR><BR>" +
"<BASEFONT COLOR=YELLOW>My Brother Henry went off to fight the beasts of Destard.<BR><BR>Seek him out.<BR>Tell him I Live!!<BR>Thank you kind adventurer!" +
						     "</BODY>", false, true);
			
//			<BASEFONT COLOR=#7B6D20>			

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

//--------------------------------------------------------------------------------------------------------------
      } 

      public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      { 
         Mobile from = state.Mobile; 

         switch ( info.ButtonID ) 
         { 
            case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            { 
               //Cancel 
               from.SendMessage( "Unite The Artifacts!!!" );
               break; 
            } 

         }
      }
   }
}