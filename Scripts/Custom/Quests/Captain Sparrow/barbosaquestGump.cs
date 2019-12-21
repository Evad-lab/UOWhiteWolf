using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class BarbosaquestGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "BarbosaquestGump", AccessLevel.GameMaster, new CommandEventHandler( BarbosaquestGump_OnCommand ) ); 
      } 

      private static void BarbosaquestGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new BarbosaquestGump( e.Mobile ) ); 
      } 

      public BarbosaquestGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Thieving Peg Leg" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=GREY>*Captain Barbossa looks deeply into your pockets* <BR>" +
"<BASEFONT COLOR=WHITE>I know why ye are here, and it will cost thee a piece of Cortez Gold, If ye are willing? <BR>" +
"<BASEFONT COLOR=GREY>*Barbosa waits for his gold*<BR>" +
"<BASEFONT COLOR=WHITE>Are ye still interested ye landlubber?<BR><BR>Ye can find this gold in Serpent's Hold. Bring me the gold, and I will tell thee the location of Peg Leg Pete." +
						     "</BODY>", false, true);
			
//			<BASEFONT COLOR=#7B6D20>			

//			AddLabel( 113, 135, 0x34, "" );
//			AddLabel( 113, 150, 0x34, "" );
//			AddLabel( 113, 165, 0x34, "" );
//			AddLabel( 113, 180, 0x34, "" );
//			AddLabel( 113, 195, 0x34, "" );
//			AddLabel( 113, 210, 0x34, "" );
//			AddLabel( 113, 235, 0x34, "" );
//			AddLabel( 113, 250, 0x34, "" );
//			AddLabel( 113, 265, 0x34, "" );
//			AddLabel( 113, 280, 0x34, "" );
//			AddLabel( 113, 295, 0x34, "" );
//			AddLabel( 113, 310, 0x34, "" );
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
               from.SendMessage( "Captain Barbossa counts his gold" );
               break; 
            } 

         }
      }
   }
}