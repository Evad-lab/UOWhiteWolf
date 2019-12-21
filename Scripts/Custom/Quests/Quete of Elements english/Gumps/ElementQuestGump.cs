using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{
    public class ElementQuestGump : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register("ElementQuestGump", AccessLevel.GameMaster, new CommandEventHandler(ElementQuestGump_OnCommand));
        }

        private static void ElementQuestGump_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendGump(new ElementQuestGump(e.Mobile));
        }

        public ElementQuestGump(Mobile owner)
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
"<BASEFONT COLOR=WHITE><I>*The Oracle looks at you fixedly while you approach*</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>Hello there young adventurer! I need your help! <BR><BR>" +
"<BASEFONT COLOR=YELLOW>I made a stupid bet! The Gods have challenged me to find an adventurer capable of giving me the four Elements.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Are you the one who will attempt such a feat? Let me give you four riddles to solve.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>You must go visit four Gods, and say his name followed by the solution to the riddle.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Each God will give you one of the Elements that you should bring back to me.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you manage to obtain each of the four Elements, I will reward you well!<BR><BR>" +
"<BASEFONT COLOR=YELLOW>So here is the first riddle.<BR><BR>" +
"<BASEFONT COLOR=WHITE>Without wing I fly,<BR><BR>" +
"<BASEFONT COLOR=WHITE>Without voice I scream,<BR><BR>" +
"<BASEFONT COLOR=WHITE>Without eyes I see,<BR><BR>" +
"<BASEFONT COLOR=WHITE>Who am I ?<BR><BR>" +
"<BASEFONT COLOR=YELLOW>You must go visit Hephaistos the God of Fire, on the isle of Lava and Chaos.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Go my friend, give the first answer and return to me the Element of the Fire !<BR><BR>" +




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

