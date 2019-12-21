using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class LutherGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "LutherGump", AccessLevel.GameMaster, new CommandEventHandler( LutherGump_OnCommand ) ); 
      } 

      private static void LutherGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new LutherGump( e.Mobile ) ); 
      } 

      public LutherGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Shield of the White Wolf" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=WHITE>*Luther looks at you and smiles...*<BR><BR>" +
"<BASEFONT COLOR = YELLOW>You must have come looking for the legendary shield of White Wolf..<BR>" +
"<BASEFONT COLOR=YELLOW>Ah, you look at my shield in such a way! So you wish one of these shields for yourself do you?<BR><BR>" +
"<BASEFONT COLOR=YELLOW>To earn this shield from me, you must kill 50 of the rapid white wolves and bring me their tails!<BR><BR>" +
"<BASEFONT COLOR=YELLOW> They may be found east of the City of Trinsic, within Trammel. The beasts have gone insane, they are very strong be warned.<BR><BR>" +
"<BASEFONT COLOR=YELLOW> The beasts do not know what they do, please put them out of their misery quickly!" +
						     "</BODY>", false, true);
			

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
               from.SendMessage( "Be safe young warrior!" );
               break; 
            } 

         }
      }
   }
}
 
