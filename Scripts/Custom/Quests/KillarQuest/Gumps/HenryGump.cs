using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class HenryGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "HenryGump", AccessLevel.GameMaster, new CommandEventHandler( HenryGump_OnCommand ) ); 
      } 

      private static void HenryGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new HenryGump( e.Mobile ) ); 
      } 

      public HenryGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Message" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW>My brother Conrad lives!!!<BR><BR>I thank thee, Great Traveler, for bringing me this message.  I was afraid all was lost!<BR>" +
"<BASEFONT COLOR=YELLOW>I have been down here for some time fighting these vile creatures that inhabit this place.<BR><BR>I have made my way to this final chamber, and the horrid beast that lies within...<BR>" +
"<BASEFONT COLOR=YELLOW>.<BR><BR>I am afraid I am not powerful enough to slay the beast.  If thou art brave enough to dispatch the being within, I shall give you what you seek.<BR>" +
"<BASEFONT COLOR=YELLOW>.<BR><BR>Bring me the Head of Reddix!!!<BR><BR>One last thing, my brother William, was headed for the frozen dungeon of Ice.  Please tell him the Brothers Killar Live!!!" +
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
               from.SendMessage( "Unite The Artifacts!!!." );
               break; 
            } 

         }
      }
   }
}