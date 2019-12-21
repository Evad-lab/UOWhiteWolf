//Scripted By James4245
using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class GandalfQuestGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("GandalfQuestGump", AccessLevel.GameMaster, new CommandEventHandler(GandalfQuestGump_OnCommand)); 
      } 

      private static void GandalfQuestGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new GandalfQuestGump( e.Mobile ) ); 
      }

       public GandalfQuestGump(Mobile owner) : base(50, 50) 
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
            AddLabel( 140, 60, 0x34, "The Gandalf Quest" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=WHITE>*Gandalf looks at you deeply*<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Oh Oooh Oooh... My brave warrior of rhe realm! <BR><BR>" +
"<BASEFONT COLOR=YELLOW>Help me kill the dreaded Dark Wizard Sauron, but be warned it is no easy task to be done.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Travel to the Hidden Valley, defeat the Dark Wizard Sauron and bring me his head. <BR><BR>" +
"<BASEFONT COLOR=WHITE>*Grins* <BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you manage to return with the head of Sauron, I will reward you with something of great value...."  +
"<BASEFONT COLOR=YELLOW>Now go find the dreaded Dark Wizard Sauron, and safe travels dear warrior" +
 
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
                from.SendMessage("Kill The Dreaded Dark Wizard Sauron And Bring Back His Head To Me");
               break; 
            } 

         }
      }
   }
}
