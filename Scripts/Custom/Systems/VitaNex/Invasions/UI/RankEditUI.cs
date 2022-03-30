#region Header
//   Vorspire    _,-'/-'/  RankEditUI.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
using System.Collections.Generic;
using System.Drawing;

using Server.Gumps;

using VitaNex.SuperGumps;
using VitaNex.SuperGumps.UI;
#endregion

namespace Server.Invasions
{
	public sealed class RankEditUI : SuperGumpList<PrizeEntry>
	{
		private string _AddPrize = String.Empty;

		public Invasion Invasion { get; private set; }
		public Rank Rank { get; private set; }

		public RankEditUI(Mobile user, Gump parent, Invasion invasion, Rank rank)
			: base(user, parent)
		{
			Invasion = invasion;
			Rank = rank;

			EntriesPerPage = 15;

			ForceRecompile = true;

			Sorted = false;
		}

		public override int GetTypeID()
		{
			return InvasionService.CSOptions.Service.GetHashCode();
		}

		protected override bool OnBeforeSend()
		{
			return base.OnBeforeSend() && Invasion != null && Rank != null;
		}

		protected override void OnSend()
		{
			base.OnSend();

			Invasion.Gumps.AddOrReplace(this);
		}

		protected override void OnClosed(bool all)
		{
			base.OnClosed(all);

			Invasion.Gumps.Remove(this);
		}

		protected override void OnHidden(bool all)
		{
			base.OnHidden(all);

			Invasion.Gumps.Remove(this);
		}

		protected override void OnDisposed()
		{
			base.OnDisposed();

			Invasion.Gumps.Remove(this);
		}

		protected override void CompileList(List<PrizeEntry> list)
		{
			list.Clear();
			list.AddRange(Rank.Prizes);

			base.CompileList(list);
		}

		protected override void CompileLayout(SuperGumpLayout layout)
		{
			base.CompileLayout(layout);

			const int width = 800, height = 600;

			var sup = SupportsUltimaStore;
			var pad = sup ? 15 : 10;
			var bgID = sup ? 40000 : 9270;
			var bgCol = sup ? Color.FromArgb(255, 41, 49, 57) : Color.Black;

			var tp = new Rectangle2D(0, 0, width, pad * 4);
			var lp = new Rectangle2D(0, tp.Height, width / 3, height - tp.Height);
			var rp = new Rectangle2D(lp.Width, tp.Height, width - lp.Width, height - tp.Height);

			layout.Add(
				"bg",
				() =>
				{
					AddBackground(0, 0, width, height, bgID);

					AddBackground(tp.X, tp.Y, tp.Width, tp.Height, bgID); // Title
					AddBackground(lp.X, lp.Y, lp.Width, lp.Height, bgID); // Left Panel
					AddBackground(rp.X, rp.Y, rp.Width, rp.Height, bgID); // Right Panel
				});

			layout.Add(
				"title",
				() =>
				{
					var title = "Rank Editor";

					if (!String.IsNullOrWhiteSpace(Rank.Name))
					{
						title += " - " + Rank.Name;
					}
					else
					{
						title += " - #" + Rank.Place;
					}

					title = title.WrapUOHtmlBig();
					title = title.WrapUOHtmlCenter();
					title = title.WrapUOHtmlColor(Color.Gold, false);

					AddHtml(tp.X + pad, tp.Y + pad, tp.Width - (pad * 2), 40, title, false, false);
				});

			layout.Add(
				"cpanel",
				() =>
				{
					var x = lp.X + pad;
					var y = lp.Y + pad;
					var w = lp.Width - (pad * 2);
					var h = lp.Height - (pad * 2);

					var label = "Control Panel";

					label = label.WrapUOHtmlBig();
					label = label.WrapUOHtmlCenter();
					label = label.WrapUOHtmlColor(Color.Gold, false);

					AddHtml(x, y, w, 40, label, false, false);

					y += 20;
					h -= 20;

					var enabled = Rank.Enabled ? "Enabled" : "Disabled";
					var color = Rank.Enabled ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleEnabled(), enabled.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnOptions(), "Options".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnClearOptions(), "Clear Options".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnClearPrizes(), "Clear Prizes".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					y += h - 120;

					AddHtmlButton(x, y, w, 30, b => OnClone(), "Clone".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;

					AddHtmlButton(x, y, w, 30, b => OnDelete(), "Delete".WrapUOHtmlCenter(), Color.IndianRed, bgCol);

					y += 30;

					AddHtmlButton(x, y, w, 30, Refresh, "Apply".WrapUOHtmlCenter(), Color.SkyBlue, bgCol);

					y += 30;

					AddHtmlButton(x, y, w, 30, Close, "Done".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
				});

			layout.Add(
				"list",
				() =>
				{
					var x = rp.X + pad;
					var y = rp.Y + pad;
					var w = rp.Width - (pad * 2);
					var h = rp.Height - (pad * 2);

					var label = "Prize List";

					label = label.WrapUOHtmlBig();
					label = label.WrapUOHtmlCenter();
					label = label.WrapUOHtmlColor(Color.Gold, false);

					AddHtml(x, y, w, 40, label, false, false);

					y += 20;
					h -= 20;

					var ec = EntriesPerPage + 1;
					var eh = Math.Min(30, (h - 30) / ec);

					var i = 0;

					var range = GetListRange();

					foreach (var o in range)
					{
						CompileEntryLayout(o.Key, x, y + (i++ * eh), w, eh, o.Value);
					}

					if (i < ec)
					{
						CompileEntryLayout(-1, x, y + (i++ * eh), w, eh, null);
					}

					y += i * eh;
					h -= i * eh;

					y += h - 30;

					w /= 2;

					var col = Color.White;

					if (HasPrevPage)
					{
						AddHtmlButton(x, y, w, 30, PreviousPage, "Prev".WrapUOHtmlCenter(), col, bgCol, col, 1);
					}

					if (HasNextPage)
					{
						AddHtmlButton(x + w, y, w, 30, NextPage, "Next".WrapUOHtmlCenter(), col, bgCol, col, 1);
					}
				});
		}

		private void CompileEntryLayout(int i, int x, int y, int w, int h, PrizeEntry o)
		{
			var sup = SupportsUltimaStore;
			var bgCol = sup ? Color.FromArgb(255, 41, 49, 57) : Color.Black;

			var cw = (w - 60) / 2;
			var cx = x + (w - 60);

			if (i < 0)
			{
				AddTextEntry(x + 12, y + 4, cw - 14, h - 8, TextHue, _AddPrize, (e, t) => _AddPrize = t);
				AddLabelCropped(x + 12 + (cw - 14) + 12, y + 4, cw - 14, h - 8, TextHue, "< Type");

				AddHtmlButton(cx, y, 60, h, b => OnAddPrize(), "ADD".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
			}
			else if (o != null)
			{
				AddColoredButton(x, y, 20, h, Color.Gold, b => OnEditPrize(o));
				AddTextEntry(x + 25, y + 4, cw - 25, h - 8, HighlightHue, o.Type.TypeName, (e, t) => ParseType(o, t));

				var ow = 25 + (cw / 2);

				AddTextEntry(x + cw + 12, y + 4, ow - 14, h - 8, TextHue, o.Amount.ToString(), (e, t) => ParseAmount(o, t));
				AddLabelCropped(x + cw + 12 + (ow - 14) + 12, y + 4, ow - 14, h - 8, TextHue, "< Amount");

				AddHtmlButton(cx, y, 60, h, b => OnRemovePrize(o), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
			}
			else
			{
				AddLabelCropped(x + 12, y + 4, (cw * 2) - 14, h - 8, TextHue, "null");
				AddHtmlButton(cx, y, 60, h, b => OnRemovePrize(null), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
			}

			AddRectangle(x, y + (h - 2), w, 2, bgCol, true);
		}

		private static void ParseType(PrizeEntry entry, string value)
		{
			if (entry == null || String.IsNullOrWhiteSpace(value))
			{
				return;
			}

			var t = entry.Type.InternalType;

			entry.Type = value;

			if (!entry.Type.IsNotNull)
			{
				entry.Type = t;
			}
		}

		private static void ParseAmount(PrizeEntry entry, string value)
		{
			if (entry == null || String.IsNullOrWhiteSpace(value))
			{
				return;
			}

			int amount;

			if (Int32.TryParse(value, out amount))
			{
				entry.Amount = Math.Max(0, amount);
			}
		}

		private void OnAddPrize()
		{
			var entry = Rank.AddPrize(_AddPrize);

			_AddPrize = String.Empty;

			Refresh(true);

			if (entry == null)
			{
				return;
			}

			List.Add(entry);

			User.SendMessage(0x55, "Prize added.");

			User.SendGump(new PropertiesGump(User, entry));
		}

		private void OnRemovePrize(PrizeEntry entry)
		{
			if (Rank.RemovePrize(entry))
			{
				User.SendMessage(0x55, "Prize removed.");
			}

			Refresh(true);
		}

		private void OnEditPrize(PrizeEntry entry)
		{
			Refresh();

			User.SendGump(new PropertiesGump(User, entry));
		}

		private void OnToggleEnabled()
		{
			Rank.Enabled = !Rank.Enabled;

			Refresh(true);
		}

		private void OnOptions()
		{
			Refresh();

			User.SendGump(new PropertiesGump(User, Rank));
		}

		private void OnClearOptions()
		{
			Rank.ClearOptions();

			Refresh(true);
		}

		private void OnClearPrizes()
		{
			Rank.Clear();

			Refresh(true);
		}

		private void OnClone()
		{
			new ConfirmDialogGump(User, Hide(true))
			{
				Title = "Clone Rank?",
				Html = "You are about to clone this rank.\n" +
					   "The new rank will be appended to this invasion and you will be taken to the new rank editor.\n\n" +
					   "Click OK to clone this rank.",
				AcceptHandler = b =>
				{
					var o = Rank.Clone();

					if (o != null)
					{
						Invasion.Ranks.Add(o);

						Rank = o;

						User.SendMessage(0x55, "Rank cloned.");
					}
					else
					{
						User.SendMessage(0x22, "Rank not cloned.");
					}

					Refresh(true);
				},
				CancelHandler = Refresh
			}.Send();
		}

		private void OnDelete()
		{
			new ConfirmDialogGump(User, Hide(true))
			{
				Title = "Delete Rank?",
				Html = "You are about to delete this rank.\nThis action can not be undone.\n\nClick OK to delete this rank.",
				AcceptHandler = b =>
				{
					if (Invasion.RemoveRank(Rank))
					{
						Close();

						User.SendMessage(0x55, "Rank removed.");
					}
					else
					{
						Refresh();
					}
				},
				CancelHandler = Refresh
			}.Send();
		}
	}
}