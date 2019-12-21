using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class SteveIrwinGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "SteveIrwinGump", AccessLevel.GameMaster, new CommandEventHandler( SteveIrwinGump_OnCommand ) ); 
      } 

      private static void SteveIrwinGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new SteveIrwinGump( e.Mobile ) ); 
      } 

      public SteveIrwinGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Lost Egg" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=WHITE>*Steve glances up with a worried look in his eyes*<BR><BR>" +
"<BASEFONT COLOR=YELLOW>G'day Mate, feel like lending me a hand??<BR>" +
"<BASEFONT COLOR=YELLOW>I was just feeding the crocs, nice little beauts, when a pesky drongo lizard man had it away with one of my precious Croc Eggs..<BR>" +
"<BASEFONT COLOR=YELLOW>So Mate, if you wanna go find the blighter and rip his bloody head off, and bring me the Egg back<BR><BR>there will be a little something in it for you.<BR>" +
"<BASEFONT COLOR=YELLOW>He was last seen heading to the Fens of the Dead north of Trinsic, Felucca ..." +						     
                                              "</BODY>", false, true);
			
//			<BASEFONT COLOR=#7B6D20>			

//			AddLabel( 113, 135, 0x34, "Steve looks at you in disbelief..." );
//			AddLabel( 113, 150, 0x34, "Steve looks at you in disbelief..." );
//			AddLabel( 113, 165, 0x34, "Eh?" );
//			AddLabel( 113, 180, 0x34, "Bah!" );
//			AddLabel( 113, 195, 0x34, "Aha?" );
//			AddLabel( 113, 210, 0x34, "Bring me the required item?" );
//			AddLabel( 113, 235, 0x34, "Bleh!" );
//			AddLabel( 113, 250, 0x34, "The item I require is the egg," );
//			AddLabel( 113, 265, 0x34, "The monster was last seen at swamp." );
//			AddLabel( 113, 280, 0x34, "Not a easy kill--" );
//			AddLabel( 113, 295, 0x34, "felled. Should you retreive the egg I shall" );
//			AddLabel( 113, 310, 0x34, "give you a nice reward" );
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
               from.SendMessage( "Ripper Mate, go get him !" );
               break; 
            } 

         }
      }
   }
}