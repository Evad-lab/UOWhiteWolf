
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
   public class VampQuestGump8 : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VampQuestGump8", AccessLevel.GameMaster, new CommandEventHandler( VampQuestGump8_OnCommand ) ); 
      } 

      private static void VampQuestGump8_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VampQuestGump8( e.Mobile ) ); 
      } 

      public VampQuestGump8( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW><I>Verona begins to tear up as she see's you approaching</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>You've did it.  Thank you so much for avenging my one true love.  Here is your reward.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>As for the information you wanted. In Cove resides a scientist who has studied vampires for as long as I've lived.  He too posses a Artifact of great value.<BR><BR>"+
"<BASEFONT COLOR=YELLOW>Carry this Amulet with you so that he knows you are a friend.  I'm sure he too could use your assistance<BR><BR>" +

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
