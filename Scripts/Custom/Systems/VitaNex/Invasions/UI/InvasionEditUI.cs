#region Header
//   Vorspire    _,-'/-'/  InvasionEditUI.cs
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

using VitaNex.Schedules;
using VitaNex.SuperGumps;
using VitaNex.SuperGumps.UI;
#endregion

namespace Server.Invasions
{
	public sealed class InvasionEditUI : SuperGumpList<object>
	{
		private static bool Swap<T>(List<T> source, int a, int b)
		{
			if (!source.InBounds(a) || !source.InBounds(b))
			{
				return false;
			}

			var x = source[a];
			var y = source[b];

			source[a] = y;
			source[b] = x;

			return true;
		}

		public Invasion Invasion { get; private set; }

		public bool RankEdit { get; set; }

		public InvasionEditUI(Mobile user, Gump parent, Invasion invasion)
			: base(user, parent)
		{
			Invasion = invasion;

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
			return base.OnBeforeSend() && Invasion != null;
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

		protected override void Compile()
		{
			base.Compile();

			Sorted = RankEdit;
		}

		protected override void CompileList(List<object> list)
		{
			list.Clear();

			if (RankEdit)
			{
				list.AddRange(Invasion.Ranks);
			}
			else
			{
				list.AddRange(Invasion.Levels);
			}

			base.CompileList(list);
		}

		public override int SortCompare(object a, object b)
		{
			var res = 0;

			if (a.CompareNull(b, ref res))
			{
				return res;
			}

			if (a is Rank && b is Rank)
			{
				var l = (Rank)a;
				var r = (Rank)b;

				if (l.Place <= 0 && r.Place > 0)
				{
					return 1;
				}

				if (l.Place > 0 && r.Place <= 0)
				{
					return -1;
				}

				if (l.Place < r.Place)
				{
					return -1;
				}

				if (l.Place > r.Place)
				{
					return 1;
				}
			}

			return base.SortCompare(a, b);
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
					var title = "Invasion Editor";

					if (!String.IsNullOrWhiteSpace(Invasion.Name))
					{
						title += " - \"" + Invasion.Name + "\"";
					}

					if (!String.IsNullOrWhiteSpace(Invasion.Region))
					{
						title += " - " + Invasion.Region;
					}

					if (RankEdit)
					{
						title += " - Ranks";
					}
					else
					{
						title += " - Levels";
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

					var value = Invasion.Enabled ? "Enabled" : "Disabled";
					var color = Invasion.Enabled ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleEnabled(), value.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					value = Invasion.IsRunning ? "Stop" : "Start";
					color = Invasion.IsRunning ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleState(), value.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					value = "Town Gates";
					color = Invasion.UseGates ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleGates(), value.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					value = "Rank Prizes";
					color = Invasion.RankPrizes ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleRankPrizes(), value.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnKillSpawns(), "Delete Invaders".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnScheduleEdit(), "Schedule".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnOptions(), "Options".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					if (RankEdit)
					{
						AddHtmlButton(x, y, w, 30, b => OnClearRanks(), "Clear Ranks".WrapUOHtmlCenter(), Color.Gold, bgCol);
					}
					else
					{
						AddHtmlButton(x, y, w, 30, b => OnClearLevels(), "Clear Levels".WrapUOHtmlCenter(), Color.Gold, bgCol);
					}

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnClearAll(), "Clear All".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					if (!RankEdit)
					{
						AddHtmlButton(x, y, w, 30, b => OnEditRanks(), "Edit Ranks".WrapUOHtmlCenter(), Color.PaleGoldenrod, bgCol);
					}
					else
					{
						AddHtmlButton(x, y, w, 30, b => OnEditLevels(), "Edit Levels".WrapUOHtmlCenter(), Color.PaleGoldenrod, bgCol);
					}

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
				"levels",
				() =>
				{
					var x = rp.X + pad;
					var y = rp.Y + pad;
					var w = rp.Width - (pad * 2);
					var h = rp.Height - (pad * 2);

					var label = (RankEdit ? "Rank" : "Level") + " List";

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

		private void CompileEntryLayout(int i, int x, int y, int w, int h, object o)
		{
			var sup = SupportsUltimaStore;
			var bgCol = sup ? Color.FromArgb(255, 41, 49, 57) : Color.Black;

			if (i >= 0 && o is Level)
			{
				var lvl = (Level)o;
				var idx = Invasion.Levels.IndexOf(lvl);

				if (idx < Invasion.Levels.Count - 1)
				{
					var g = "\u25BC".WrapUOHtmlSmall().WrapUOHtmlCenter();

					AddHtmlButton(x, y, 20, h, b => OnMoveLevelDown(lvl), g, Color.IndianRed, bgCol);
				}

				x += 20;
				w -= 20;

				if (idx > 0)
				{
					var g = "\u25B2".WrapUOHtmlSmall().WrapUOHtmlCenter();

					AddHtmlButton(x, y, 20, h, b => OnMoveLevelUp(lvl), g, Color.LawnGreen, bgCol);
				}

				x += 20;
				w -= 20;

				x += 5;
				w -= 5;
			}

			var cw = (w - 60) / 2;
			var cx = x + (w - 60);

			if (i < 0)
			{
				if (RankEdit)
				{
					AddHtmlButton(cx, y, 60, h, b => OnAddRank(), "ADD".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
				}
				else
				{
					AddHtmlButton(cx, y, 60, h, b => OnAddLevel(), "ADD".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
				}
			}
			else if (o != null)
			{
				if (o is Level)
				{
					var l = (Level)o;

					var name = l.Name;

					if (String.IsNullOrWhiteSpace(name))
					{
						name = "Level " + (i + 1);
					}

					AddColoredButton(x, y, 20, h, Color.Gold, b => OnEditLevel(l));
					AddTextEntry(x + 25, y + 4, cw - 25, h - 8, HighlightHue, name, (e, t) => ParseName(l, t));

					var ow = 25 + (cw / 2);

					AddTextEntry(x + cw + 12, y + 4, ow - 14, h - 8, TextHue, l.SpawnAmount.ToString(), (e, t) => ParseAmount(l, t));
					AddLabelCropped(x + cw + 12 + (ow - 14) + 12, y + 4, ow - 14, h - 8, TextHue, "< Spawns");

					AddHtmlButton(cx, y, 40, h, b => OnRemoveLevel(l), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
					AddColoredButton(cx + 40, y, 20, h, l.Enabled ? Color.LawnGreen : Color.IndianRed, b => OnToggleLevel(l));
				}
				else if (o is Rank)
				{
					var r = (Rank)o;

					var name = r.Name;

					if (String.IsNullOrWhiteSpace(name))
					{
						name = "Rank " + r.Place;
					}

					AddColoredButton(x, y, 20, h, Color.Gold, b => OnEditRank(r));
					AddTextEntry(x + 25, y + 4, cw - 25, h - 8, HighlightHue, name, (e, t) => ParseName(r, t));

					var ow = 25 + (cw / 2);

					AddTextEntry(x + cw + 12, y + 4, ow - 14, h - 8, TextHue, r.Place.ToString(), (e, t) => ParsePlace(r, t));
					AddLabelCropped(x + cw + 12 + (ow - 14) + 12, y + 4, ow - 14, h - 8, TextHue, "< Place");

					AddHtmlButton(cx, y, 40, h, b => OnRemoveRank(r), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
					AddColoredButton(cx + 40, y, 20, h, r.Enabled ? Color.LawnGreen : Color.IndianRed, b => OnToggleRank(r));
				}
			}
			else
			{
				AddLabelCropped(x + 12, y + 4, (cw * 2) - 14, h - 8, TextHue, "null");

				if (RankEdit)
				{
					AddHtmlButton(cx, y, 60, h, b => OnRemoveRank(null), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
				}
				else
				{
					AddHtmlButton(cx, y, 60, h, b => OnRemoveLevel(null), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
				}
			}

			AddRectangle(x, y + (h - 2), w, 2, bgCol, true);
		}

		private static void ParseName(Level entry, string value)
		{
			if (entry == null)
			{
				return;
			}

			if (String.IsNullOrWhiteSpace(value) || Insensitive.StartsWith(value, "Level"))
			{
				value = null;
			}

			entry.Name = value;
		}

		private static void ParseAmount(Level entry, string value)
		{
			if (entry == null || String.IsNullOrWhiteSpace(value))
			{
				return;
			}

			int amount;

			if (Int32.TryParse(value, out amount))
			{
				entry.SpawnAmount = Math.Max(0, amount);
			}
		}

		private static void ParseName(Rank entry, string value)
		{
			if (entry == null)
			{
				return;
			}

			if (String.IsNullOrWhiteSpace(value) || Insensitive.StartsWith(value, "Rank"))
			{
				value = null;
			}

			entry.Name = value;
		}

		private static void ParsePlace(Rank entry, string value)
		{
			if (entry == null || String.IsNullOrWhiteSpace(value))
			{
				return;
			}

			int amount;

			if (Int32.TryParse(value, out amount))
			{
				entry.Place = Math.Max(0, amount);
			}
		}

		private void OnAddLevel()
		{
			var entry = Invasion.AddLevel();

			if (entry == null)
			{
				Refresh(true);
				return;
			}

			List.Add(entry);

			Page = PageCount + 1;

			User.SendMessage(0x55, "Level added.");

			new LevelEditUI(User, Hide(), Invasion, entry).Send();
		}

		private void OnRemoveLevel(Level entry)
		{
			if (Invasion.RemoveLevel(entry))
			{
				User.SendMessage(0x55, "Level removed.");
			}

			Refresh(true);
		}

		private void OnEditLevel(Level entry)
		{
			new LevelEditUI(User, Hide(), Invasion, entry).Send();
		}

		private void OnToggleLevel(Level entry)
		{
			entry.Enabled = !entry.Enabled;

			Refresh(true);
		}

		private void OnMoveLevelUp(Level level)
		{
			var idx = Invasion.Levels.IndexOf(level);

			Swap(Invasion.Levels, idx, idx - 1);

			Refresh(true);
		}

		private void OnMoveLevelDown(Level level)
		{
			var idx = Invasion.Levels.IndexOf(level);

			Swap(Invasion.Levels, idx, idx + 1);

			Refresh(true);
		}

		private void OnAddRank()
		{
			var entry = Invasion.AddRank();

			if (entry == null)
			{
				Refresh(true);
				return;
			}

			List.Add(entry);

			Page = PageCount + 1;

			User.SendMessage(0x55, "Rank added.");

			new RankEditUI(User, Hide(), Invasion, entry).Send();
		}

		private void OnRemoveRank(Rank entry)
		{
			if (Invasion.RemoveRank(entry))
			{
				User.SendMessage(0x55, "Rank removed.");
			}

			Refresh(true);
		}

		private void OnEditRank(Rank entry)
		{
			new RankEditUI(User, Hide(), Invasion, entry).Send();
		}

		private void OnToggleRank(Rank entry)
		{
			entry.Enabled = !entry.Enabled;

			Refresh(true);
		}

		private void OnToggleEnabled()
		{
			Invasion.Enabled = !Invasion.Enabled;

			Refresh(true);
		}

		private void OnToggleState()
		{
			if (Invasion.IsRunning)
			{
				if (Invasion.Stop(true))
				{
					User.SendMessage(0x55, "Invasion stopped.");
				}
				else
				{
					User.SendMessage(0x22, "Invasion not stopped.");
				}
			}
			else
			{
				string status;

				if (Invasion.Start(out status))
				{
					User.SendMessage(0x55, "Invasion started.");
				}
				else
				{
					User.SendMessage(0x22, "Invasion not started.");
				}

				if (!String.IsNullOrWhiteSpace(status))
				{
					User.SendMessage(status);
				}
			}

			Refresh(true);
		}

		private void OnToggleGates()
		{
			Invasion.UseGates = !Invasion.UseGates;

			Invasion.InvalidateGates();

			Refresh(true);
		}

		private void OnToggleRankPrizes()
		{
			Invasion.RankPrizes = !Invasion.RankPrizes;

			Refresh(true);
		}

		private void OnKillSpawns()
		{
			Invasion.DeleteInvaders();

			User.SendMessage(0x55, "Current invaders deleted.");

			Refresh(true);
		}

		private void OnScheduleEdit()
		{
			new ScheduleOverviewGump(User, Invasion.Schedule, Hide()).Send();
		}

		private void OnOptions()
		{
			Refresh();

			User.SendGump(new PropertiesGump(User, Invasion));
		}

		private void OnClearLevels()
		{
			Invasion.ClearLevels();

			Refresh(true);
		}

		private void OnClearRanks()
		{
			Invasion.ClearRanks();

			Refresh(true);
		}

		private void OnClearAll()
		{
			Invasion.Clear();

			Refresh(true);
		}

		private void OnEditRanks()
		{
			RankEdit = true;

			Refresh(true);
		}

		private void OnEditLevels()
		{
			RankEdit = false;

			Refresh(true);
		}

		private void OnClone()
		{
			new ConfirmDialogGump(User, Hide(true))
			{
				Title = "Clone Invasion?",
				Html = "You are about to clone this invasion.\nYou will be taken to the new invasion editor.\n\n" +
					   "Click OK to clone this invasion.",
				AcceptHandler = b =>
				{
					var o = Invasion.Clone();

					if (o != null)
					{
						InvasionService.Invasions[o.UID] = o;

						Invasion = o;

						User.SendMessage(0x55, "Invasion cloned.");
					}
					else
					{
						User.SendMessage(0x22, "Invasion not cloned.");
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
				Title = "Delete Invasion?",
				Html = "You are about to delete this invasion.\nThis action can not be undone.\n\n" +
					   "Click OK to delete this invasion.",
				AcceptHandler = b =>
				{
					Invasion.Delete();
					Close();

					User.SendMessage(0x55, "Invasion removed.");
				},
				CancelHandler = Refresh
			}.Send();
		}
	}
}