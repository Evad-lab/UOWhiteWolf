
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
   public class VampQuestGump9 : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VampQuestGump9", AccessLevel.GameMaster, new CommandEventHandler( VampQuestGump9_OnCommand ) ); 
      } 

      private static void VampQuestGump9_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VampQuestGump9( e.Mobile ) ); 
      } 

      public VampQuestGump9( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW><I>Simeon looks up from his research giving you a slight glace as you walk through the door only giving you his full attention when he sees that you are coming towards him</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>Umm umm Ohhh... What can I do for you?<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Ahhh I see... Well I would consider giving you my relic if you'd be willing to gather me some Vampires Blood<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Oh and you would want information on where you could find more of such artifacts... Hrm.  Okay take these vials and fill them with the blood of the Vampires then we shall do or trading<BR><BR>" +
			
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
               				from.SendMessage( "Thank you so much for aiding me" );
               				break; 
            			} 
         		}
      		}
   	}
}
