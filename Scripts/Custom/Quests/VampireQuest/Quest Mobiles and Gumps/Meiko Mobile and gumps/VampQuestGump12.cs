
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
   public class VampQuestGump12 : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VampQuestGump12", AccessLevel.GameMaster, new CommandEventHandler( VampQuestGump12_OnCommand ) ); 
      } 

      private static void VampQuestGump12_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VampQuestGump12( e.Mobile ) ); 
      } 

      public VampQuestGump12( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW><I>You dive out of the way as an arrow flys past your head. As you regain composour you notice that Meiko is standing over you surprised that he missed you.</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>Oh, oh I'm so sorry I thought you was a vampire. Have you got it?  My God man you got it! here is the ring as I promised.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>And as for the information I promised there is a special trick to the ring which you now have.  It's said that if you gather together all the items created by Dracula and dbl Click the ring" +
"<BASEFONT COLOR=YELLOW>you will receive the the keys to Draculas inner chamber...  I've never been able to gather all the items in all my years but goodluck " +
"<BASEFONT COLOR=YELLOW>Oh by the way the gate that leads you to the inner chamber is near Umbra tucked away in a cave<br><br>" +

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
               				from.SendMessage( "Good Luck" );
               				break; 
            			} 
         		}
      		}
   	}
}
