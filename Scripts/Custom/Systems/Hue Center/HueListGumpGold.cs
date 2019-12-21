#region References

using System;
using System.Collections;
using Server.Items;
using Server.Mobiles;
using Server.Network;

#endregion

namespace Server.Gumps
{
	public class HueListGumpGold : Gump
	{
		private ArrayList Rewards;

		private int y_inc = 20;
		private int x_creditoffset = 100;
		private int x_pointsoffset = 280; //was 480
		private int maxItemsPerPage = 25;
		private readonly int viewpage;

		public const int TOTAL_HUES = 3000;

		public HueListGumpGold(Mobile from, int page) : base(20, 30)
		{
			from.CloseGump(typeof (HueListGumpGold));

			viewpage = page;

			int height = maxItemsPerPage*y_inc + 120;
			int width = x_pointsoffset + 65;

			PlayerMobile pm = from as PlayerMobile;

			AddBackground(0, 0, width, height, 0xA28 /*0x2436*/);

			AddHtml(0, 20, width, 50, "<basefont color=yellow><center>THE HUE CENTER", false, false);//Edit the title 

			AddLabel(width - 175, 40, 1271, String.Format("100k Per One Use Tub"));

			AddButton(45, height - 35, 0xFB7, 0xFB9, 0, GumpButtonType.Reply, 0);
			AddLabel(80, height - 35, 0, "Close");


			AddLabel(width - 205, height - 35, 1149, String.Format("Page: {0}/{1}", viewpage + 1, 3000/maxItemsPerPage + 1));

			// page up and down buttons
			AddButton(width - 85, height - 35, 0x15E0, 0x15E4, 13, GumpButtonType.Reply, 0);
			AddButton(width - 65, height - 35, 0x15E2, 0x15E6, 12, GumpButtonType.Reply, 0);

			AddLabel(50, 50, 32, "Hue");

			int y = 50;
			for (int i = 0; i < TOTAL_HUES; i++)
			{
				if (i/maxItemsPerPage != viewpage)
				{
					continue;
				}

				y += y_inc;

				int texthue = i;
				string color = Convert.ToString(texthue + 1);

				AddLabel(50, y + 3, texthue, color);

				AddItem(x_creditoffset, y, 0xFAB, texthue + 1);

				//The Button That Hues
				AddButton(width - 180, y, 0x992, 0x993, i + 4000, GumpButtonType.Reply, 0);
			}

			AddHtml(width - 120, height - 400, 90, 200,
				@"<basefont color = cyan><center>Enter a hue number to jump directly to it's page:", false, false);
			AddAlphaRegion(width - 110, height - 320, 65, 20);
			AddTextEntry(width - 110, height - 320, 65, 20, 54, 14, @"1");
			AddButton(width - 40, height - 317, 2224, 2224, 15, GumpButtonType.Reply, 0);
		}

		public override void OnResponse(NetState state, RelayInfo info)
		{
			if (info == null || state == null || state.Mobile == null)
			{
				return;
			}

			Mobile from = state.Mobile;
			bool bought = false;

			switch (info.ButtonID)
			{
				case 12:
					// page up
					int nitems = 0;
					nitems = 3000;

					int page = viewpage + 1;
					if (page > nitems/maxItemsPerPage)
					{
						page = nitems/maxItemsPerPage;
					}
					state.Mobile.SendGump(new HueListGumpGold(state.Mobile, page));
					break;
				case 13:
					// page down
					page = viewpage - 1;
					if (page < 0)
					{
						page = 0;
					}
					state.Mobile.SendGump(new HueListGumpGold(state.Mobile, page));
					break;
				case 15:
				{
					// go to hue page
					int hueToFind = 0;

					string huestring = info.GetTextEntry(14).Text;

					try
					{
						hueToFind = Convert.ToInt32(huestring, 10);
					}
					catch
					{
						hueToFind = 1;
					}

					if (hueToFind < 1)
					{
						hueToFind = 1;
					}

					if (hueToFind > TOTAL_HUES)
					{
						hueToFind = TOTAL_HUES;
					}

					if (hueToFind == null)
					{
						hueToFind = 1;
					}

					//int toalpages = TOTAL_HUES/maxItemsPerPage;
					int pageHueFound = (hueToFind - 1)/maxItemsPerPage;

					state.Mobile.SendGump(new HueListGumpGold(state.Mobile, pageHueFound));

					break;
				}
				default:
				{
					if (info.ButtonID >= 4000 && info.ButtonID < 7001)
					{
						int hueselection = info.ButtonID - 3999;
						int pageHueFound = (hueselection)/maxItemsPerPage;

                             if (from.BankBox.ConsumeTotal( typeof( Gold ), 100000 ))
                        {
                            UniversalDyeTub rdt = new UniversalDyeTub();
                            rdt.Hue = hueselection;
                            rdt.Hue = hueselection;
                            state.Mobile.AddToBackpack(rdt);
 
                            state.Mobile.SendMessage("You purchase a one use rare dye tub with hue {0}.", hueselection.ToString());
                            state.Mobile.SendGump(new HueListGumpGold(state.Mobile, pageHueFound));
                            bought = false;
                        }
                        state.Mobile.SendMessage("There was not enough gold in your Bank Box to purchase a dye tub.");

						break;
					}
					break;
				}
			}
		}
	}
}