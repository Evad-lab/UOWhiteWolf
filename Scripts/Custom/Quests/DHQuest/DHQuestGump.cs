// Created using GumpStudio and Scripted by Karmageddon

using System;
using System.Collections;
using Server;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Commands;

namespace Server.Gumps
{
	public class DHQuestGump : Gump
	{
	   public static void Initialize() 
      	   { 
         	CommandSystem.Register( "DHQuestGump", AccessLevel.GameMaster, new CommandEventHandler( DHQuestGump_OnCommand ) ); 
      	   } 

      	   private static void DHQuestGump_OnCommand( CommandEventArgs e ) 
      	   { 
         	e.Mobile.SendGump( new DHQuestGump( e.Mobile ) ); 
      	   }
      	
		public DHQuestGump( Mobile owner ) : base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=false;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(70, 46, 309, 408, 3500);
			this.AddImage(29, 23, 10440);
			this.AddImage(338, 23, 10441);
			this.AddImage(325, 395, 3635);
			this.AddImage(100, 394, 3635);
			this.AddButton(131, 405, 2642, 2643, 0, GumpButtonType.Reply, 0);
			this.AddLabel(177, 416, 37, @"Okay");
			this.AddLabel(135, 58, 37, @"Quest of the Dragon Hearts");
			this.AddImage(89, 79, 5609);
			this.AddImage(302, 79, 5609);
			
			this.AddHtml( 101, 145, 242, 160, "<BODY>" +			
			"<BASEFONT COLOR=Red><I>The ancient smith looks up at you trying to focus on you from the forge he is working at.<br>" +
			"<BASEFONT Color=Red><I>So you wish to have a piece of my special crafted armor, huh? Well I am all out of the supplies I need.<br>" + 
			"<BASEFONT COLOR=Red><I>So if you want some you must bring me the things needed to craft my special armor.<br>" +
			"<BASEFONT COLOR=Red><I>There are 2 things I need to craft you a piece of armor, Dragon Ore and the Dragon Heart.<br>" +
			"<BASEFONT COLOR=Red><I>I must warn you this will not be an easy task, for the keeper of the heart will not give the heart up so easily.<br>" + 
			"</BODY>", false, true);

		}
		
		public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      		{ 
         		Mobile from = state.Mobile; 

         		switch ( info.ButtonID ) 
         		{ 
            			case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            	{ 
               		//Cancel 
               		from.SendMessage( "Be sure to read your book to find out what you need to do." );
               		break; 
            	}
            }
	}
     }
}