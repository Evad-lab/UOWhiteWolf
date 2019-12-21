#region Header
//   Vorspire    _,-'/-'/  LevelEditUI.cs
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
	public sealed class LevelEditUI : SuperGumpList<object>
	{
		private string _AddLoot = String.Empty;
		private string _AddSpawn = String.Empty;

		public Invasion Invasion { get; private set; }
		public Level Level { get; private set; }

		public bool LootEdit { get; set; }

		public LevelEditUI(Mobile user, Gump parent, Invasion invasion, Level level)
			: base(user, parent)
		{
			Invasion = invasion;
			Level = level;

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
			return base.OnBeforeSend() && Invasion != null && Level != null;
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

		protected override void CompileList(List<object> list)
		{
			list.Clear();

			if (LootEdit)
			{
				list.AddRange(Level.Loot);
			}
			else
			{
				list.AddRange(Level.Spawn);
			}

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
					var title = "Level Editor";

					if (!String.IsNullOrWhiteSpace(Level.Name))
					{
						title += " - " + Level.Name;
					}
					else
					{
						title += " - #" + (Invasion.Levels.IndexOf(Level) + 1);
					}

					if (LootEdit)
					{
						title += " - Loot";
					}
					else
					{
						title += " - Spawn";
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

					var enabled = Level.Enabled ? "Enabled" : "Disabled";
					var color = Level.Enabled ? Color.LawnGreen : Color.IndianRed;

					AddHtmlButton(x, y, w, 30, b => OnToggleEnabled(), enabled.WrapUOHtmlCenter(), color, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnOptions(), "Options".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnClearOptions(), "Clear Options".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					if (LootEdit)
					{
						AddHtmlButton(x, y, w, 30, b => OnClearLoot(), "Clear Loot".WrapUOHtmlCenter(), Color.Gold, bgCol);
					}
					else
					{
						AddHtmlButton(x, y, w, 30, b => OnClearSpawn(), "Clear Spawn".WrapUOHtmlCenter(), Color.Gold, bgCol);
					}

					y += 30;
					h -= 30;

					AddHtmlButton(x, y, w, 30, b => OnClearAll(), "Clear All".WrapUOHtmlCenter(), Color.Gold, bgCol);

					y += 30;
					h -= 30;

					if (!LootEdit)
					{
						AddHtmlButton(x, y, w, 30, b => OnEditLoot(), "Edit Loot".WrapUOHtmlCenter(), Color.PaleGoldenrod, bgCol);
					}
					else
					{
						AddHtmlButton(x, y, w, 30, b => OnEditSpawn(), "Edit Spawn".WrapUOHtmlCenter(), Color.PaleGoldenrod, bgCol);
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
				"list",
				() =>
				{
					var x = rp.X + pad;
					var y = rp.Y + pad;
					var w = rp.Width - (pad * 2);
					var h = rp.Height - (pad * 2);

					var label = (LootEdit ? "Loot" : "Spawn") + " List";

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

			var cw = (w - 60) / 2;
			var cx = x + (w - 60);

			if (i < 0)
			{
				if (LootEdit)
				{
					AddTextEntry(x + 12, y + 4, cw - 14, h - 8, TextHue, _AddLoot, (e, t) => _AddLoot = t);
					AddLabelCropped(x + 12 + (cw - 14) + 12, y + 4, cw - 14, h - 8, TextHue, "< Loot Type");

					AddHtmlButton(x + (w - 60), y, 60, h, b => OnAddLoot(), "ADD".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
				}
				else
				{
					AddTextEntry(x + 12, y + 4, cw - 14, h - 8, TextHue, _AddSpawn, (e, t) => _AddSpawn = t);
					AddLabelCropped(x + 12 + (cw - 14) + 12, y + 4, cw - 14, h - 8, TextHue, "< Spawn Type");

					AddHtmlButton(cx, y, 60, h, b => OnAddSpawn(), "ADD".WrapUOHtmlCenter(), Color.LawnGreen, bgCol);
				}
			}
			else if (o != null)
			{
				if (o is LootEntry)
				{
					var l = (LootEntry)o;

					AddColoredButton(x, y, 20, h, Color.Gold, b => OnEditLoot(l));
					AddTextEntry(x + 25, y + 4, cw - 25, h - 8, HighlightHue, l.Type.TypeName, (e, t) => ParseType(l, t));

					var ow = 25 + (cw / 2);

					AddTextEntry(x + cw + 12, y + 4, ow - 14, h - 8, TextHue, l.Amount.ToString(), (e, t) => ParseAmount(l, t));
					AddLabelCropped(x + cw + 12 + (ow - 14) + 12, y + 4, ow - 14, h - 8, TextHue, "< Amount");

					AddHtmlButton(cx, y, 60, h, b => OnRemoveLoot(l), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
				}
				else if (o is Spawn)
				{
					var s = (Spawn)o;

					AddColoredButton(x, y, 20, h, Color.Gold, b => OnEditSpawn(s));
					AddTextEntry(x + 25, y + 4, (cw * 2) - 25, h - 8, HighlightHue, s.Type.TypeName, (e, t) => ParseType(s, t));

					AddHtmlButton(cx, y, 40, h, b => OnRemoveSpawn(s), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
					AddColoredButton(cx + 40, y, 20, h, s.Enabled ? Color.LawnGreen : Color.IndianRed, b => OnToggleSpawn(s));
				}
			}
			else
			{
				AddLabelCropped(x + 12, y + 4, (cw * 2) - 14, h - 8, TextHue, "null");

				if (LootEdit)
				{
					AddHtmlButton(cx, y, 60, h, b => OnRemoveLoot(null), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
				}
				else
				{
					AddHtmlButton(cx, y, 60, h, b => OnRemoveSpawn(null), "DEL".WrapUOHtmlCenter(), Color.IndianRed, bgCol);
				}
			}

			AddRectangle(x, y + (h - 2), w, 2, bgCol, true);
		}

		private static void ParseType(Spawn entry, string value)
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

		private static void ParseType(LootEntry entry, string value)
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

		private static void ParseAmount(LootEntry entry, string value)
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

		private void OnAddLoot()
		{
			var entry = Level.AddLoot(_AddLoot);

			_AddLoot = String.Empty;

			Refresh(true);

			if (entry == null)
			{
				return;
			}

			List.Add(entry);

			User.SendMessage(0x55, "Loot added.");

			User.SendGump(new PropertiesGump(User, entry));
		}

		private void OnRemoveLoot(LootEntry entry)
		{
			if (Level.RemoveLoot(entry))
			{
				User.SendMessage(0x55, "Loot removed.");
			}

			Refresh(true);
		}

		private void OnEditLoot(LootEntry entry)
		{
			Refresh();

			User.SendGump(new PropertiesGump(User, entry));
		}

		private void OnAddSpawn()
		{
			var entry = Level.AddSpawn(_AddSpawn);

			_AddSpawn = String.Empty;

			if (entry == null)
			{
				Refresh(true);
				return;
			}

			List.Add(entry);

			Page = PageCount + 1;

			User.SendMessage(0x55, "Spawn added.");

			new SpawnEditUI(User, Hide(), Invasion, Level, entry).Send();
		}

		private void OnRemoveSpawn(Spawn entry)
		{
			if (Level.RemoveSpawn(entry))
			{
				User.SendMessage(0x55, "Spawn removed.");
			}

			Refresh(true);
		}

		private void OnEditSpawn(Spawn entry)
		{
			new SpawnEditUI(User, Hide(), Invasion, Level, entry).Send();
		}

		private void OnToggleSpawn(Spawn entry)
		{
			entry.Enabled = !entry.Enabled;

			Refresh(true);
		}

		private void OnToggleEnabled()
		{
			Level.Enabled = !Level.Enabled;

			Refresh(true);
		}

		private void OnOptions()
		{
			Refresh();

			User.SendGump(new PropertiesGump(User, Level));
		}

		private void OnClearOptions()
		{
			Level.ClearOptions();

			Refresh(true);
		}

		private void OnClearLoot()
		{
			Level.ClearLoot();

			Refresh(true);
		}

		private void OnClearSpawn()
		{
			Level.ClearSpawn();

			Refresh(true);
		}

		private void OnClearAll()
		{
			Level.Clear();

			Refresh(true);
		}

		private void OnEditLoot()
		{
			LootEdit = true;

			Refresh(true);
		}

		private void OnEditSpawn()
		{
			LootEdit = false;

			Refresh(true);
		}

		private void OnClone()
		{
			new ConfirmDialogGump(User, Hide(true))
			{
				Title = "Clone Level?",
				Html = "You are about to clone this level.\n" +
					   "The new level will be appended to this invasion and you will be taken to the new level editor.\n\n" +
					   "Click OK to clone this level.",
				AcceptHandler = b =>
				{
					var o = Level.Clone();

					if (o != null)
					{
						Invasion.Levels.Add(o);

						Level = o;

						User.SendMessage(0x55, "Level cloned.");
					}
					else
					{
						User.SendMessage(0x22, "Level not cloned.");
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
				Title = "Delete Level?",
				Html = "You are about to delete this level.\nThis action can not be undone.\n\nClick OK to delete this level.",
				AcceptHandler = b =>
				{
					if (Invasion.RemoveLevel(Level))
					{
						Close();

						User.SendMessage(0x55, "Level removed.");
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