
//////////////////////////
//Created by LostSinner//
////////////////////////
using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class VampQuestGump7 : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VampQuestGump7", AccessLevel.GameMaster, new CommandEventHandler( VampQuestGump7_OnCommand ) ); 
      } 

      private static void VampQuestGump7_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VampQuestGump7( e.Mobile ) ); 
      } 

      public VampQuestGump7( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Vampire Quest by Lost Sinner" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW><I>I see you have the letter... So you've come to help me</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW><I>Verona looks at you with anger in her eyes as she explains what happend</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>They killed him <I>She cries</I> Those damn Vampires killed my true love.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you seek revenge on them for me I'll reward you with a precious item crafted by Dracula himself as well as information on where to find another item of such value.  Fill these Empty Vengence Gems with the spirit of the Vampires you slay and bring them back to me<BR><BR>" +
 
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
              				 from.SendMessage( "Safe travels valiant warrior" );
            			   		break; 
				} 
			}
		}
	}
}
