using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class MMQMycologistGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "MMQMycologistGump", AccessLevel.GameMaster, new CommandEventHandler( MMQMycologistGump_OnCommand ) ); 
      } 

      private static void MMQMycologistGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new MMQMycologistGump( e.Mobile ) ); 
      } 

      public MMQMycologistGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Lighthouse Keeper Quest" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=White><I>The Legendary Mycologist looks at you with content.</I><br><br>" +
"<BASEFONT Color=White>Welcome to my home. I have recently earned the title of a Legendary Mycologist. This means that my study of fungus has received great recognition throughout the land.<br><br>" + 
"<BASEFONT COLOR=White>I have only one problem. I seemed to have run out of Magical Mushroom Spores. I really need more spores to continue my research.<br><br>" +
"<BASEFONT COLOR=White>You see, I have been working on a way to develop a mushroom that will allow personal statistical enhancement for a lifetime!<br><br>" +
"<BASEFONT COLOR=White>Unfortunately, I have not been able to develop this string of mushroom yet. However, I have made quite a few advancements.<br><br>" +
"<BASEFONT COLOR=White>If you bring me back some Magical Mushroom Spores, I will be more than happy to reward your efforts.<br><br>" +
"<BASEFONT COLOR=White>The last person to help me said that the spores are located in the stomach of a slimey creature. I would try looking on the island of Haven. Just look for a ring of mushrooms.<br>" + 
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
               from.SendMessage( "Legendary Mycologist Says: Be aware, the Fungus Eating Slime is quite poisonous!" );
               break; 
            } 

         }
      }
   }
}