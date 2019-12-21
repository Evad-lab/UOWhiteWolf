using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class AlGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("AlGump", AccessLevel.GameMaster, new CommandEventHandler(AlGump_OnCommand)); 
      } 

      private static void AlGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new AlGump( e.Mobile ) ); 
      } 

      public AlGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Reagent Key Quest" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=WHITE><I>* The old mage looks at you with anger in his eyes *</I><br><br>" +
"<BASEFONT Color=YELLOW> Why are you here?! I should destroy you with my magic !!<br><br>" + 
"<BASEFONT COLOR=YELLOW> I do not wish to fight you. What I do want is my Massive Mandrake. It was taken by a foolish mage named Al. Can you help me?<br><br>" +
"<BASEFONT COLOR=YELLOW> You see, I am too old to fight him, but if you can defeat him and get my mandrake back, I will give you a storage key to hold your reagents.<br><br>" +
"<BASEFONT COLOR=YELLOW> Al lives inside the Ice Dungeon, in Felucca.<br><br>" +
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
               from.SendMessage( "Please return my mandrake!!!" );
               break; 
            } 

         }
      }
   }
}