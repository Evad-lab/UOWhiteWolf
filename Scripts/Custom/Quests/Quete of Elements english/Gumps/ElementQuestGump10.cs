using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{
    public class ElementQuestGump10 : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register("ElementQuestGump10", AccessLevel.GameMaster, new CommandEventHandler(ElementQuestGump10_OnCommand));
        }

        private static void ElementQuestGump10_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendGump(new ElementQuestGump10(e.Mobile));
        }

        public ElementQuestGump10(Mobile owner)
            : base(50, 50)
        {
            //----------------------------------------------------------------------------------------------------

            AddPage(0);
            AddImageTiled(54, 33, 369, 400, 2624);
            AddAlphaRegion(54, 33, 369, 400);

            AddImageTiled(416, 39, 44, 389, 203);
            //--------------------------------------Window size bar--------------------------------------------

            AddImage(97, 49, 9005);
            AddImageTiled(58, 39, 29, 390, 10460);
            AddImageTiled(412, 37, 31, 389, 10460);
            AddLabel(140, 60, 0x34, "Four Elements's Quest");


            AddHtml(107, 140, 300, 230, "<BODY>" +
                //----------------------/----------------------------------------------/

"<BASEFONT COLOR=YELLOW>Very good! You possess as much wisdom as you do courage.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>As promised, here is a reward that you so amply deserve.<BR><BR>" +
"<BASEFONT COLOR=WHITE>*Pythie gives you a Bracelet of Elements*<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Thank you so much for your help. The Oracle really appreciates what you have done for him.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Goodbye young adventurer!<BR><BR>" +



            "</BODY>", false, true);


            AddImage(430, 9, 10441);
            AddImageTiled(40, 38, 17, 391, 9263);
            AddImage(6, 25, 10421);
            AddImage(34, 12, 10420);
            AddImageTiled(94, 25, 342, 15, 10304);
            AddImageTiled(40, 427, 415, 16, 10304);
            AddImage(-10, 314, 10402);
            AddImage(56, 150, 10411);
            AddImage(155, 120, 2103);
            AddImage(136, 84, 96);

            AddButton(225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0);

            //--------------------------------------------------------------------------------------------------------------
        }

        public override void OnResponse(NetState state, RelayInfo info) //Function for GumpButtonType.Reply Buttons 
        {
            Mobile from = state.Mobile;

            switch (info.ButtonID)
            {
                case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
                    {
                        break;
                    }
            }
        }
    }
}

