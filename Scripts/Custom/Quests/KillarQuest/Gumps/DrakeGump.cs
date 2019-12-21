using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class DrakeGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "DrakeGump", AccessLevel.GameMaster, new CommandEventHandler( DrakeGump_OnCommand ) ); 
      } 

      private static void DrakeGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new DrakeGump( e.Mobile ) ); 
      } 

      public DrakeGump( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW>My brothers live!!!<BR><BR>I thank thee, Great Traveler, for bringing me this great news.  I was afraid all was lost!<BR>" +
"<BASEFONT COLOR=YELLOW>I have been down here for some time fighting these vile creatures that inhabit this pit of fire.<BR><BR>I have made my way to this final chamber, and the Daemon that lies within...<BR>" +
"<BASEFONT COLOR=YELLOW>.<BR><BR>I am afraid I lack the strength to complete my task.  If thou art brave enough to dispatch the being within, I shall give you what you seek.<BR>" +
"<BASEFONT COLOR=YELLOW>.<BR><BR>Bring me the Head of Molach!!!<BR><BR>Return to my brother Conrad.  He will surely reward thee for thy courage!!!" +
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