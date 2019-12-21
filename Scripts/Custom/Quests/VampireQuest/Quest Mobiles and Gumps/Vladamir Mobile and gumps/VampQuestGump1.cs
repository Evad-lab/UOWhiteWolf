
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
   public class VampQuestGump1 : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VampQuestGump1", AccessLevel.GameMaster, new CommandEventHandler( VampQuestGump1_OnCommand ) ); 
      } 

      private static void VampQuestGump1_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VampQuestGump1( e.Mobile ) ); 
      } 

      public VampQuestGump1( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW>Very well done I must say but it's only the beggining <I>*Laughs*</I> Now go North of Britian there is a hollowed out area in the mountians where Celeste another great Vampire dwells<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Take this knife and cut out her heart as well.  Why do I want their hearts <I>*Chuckles*</I> That I cannot tell you as of yet. But soon<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Take this knife to carve her heart from her chest. Why? boy you ask alot of questions. Well these vampires are very strong and to peirce their skin one must use their weaknesses put into blade form.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Now hurry on.  Oh by the way DBL Click that peice of amror I gave you and enjoy!!!<BR><BR>" +
			
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
               				from.SendMessage( "GoodLuck" );
               				break; 
            			}	 
         		}
      		}
   	}
}
