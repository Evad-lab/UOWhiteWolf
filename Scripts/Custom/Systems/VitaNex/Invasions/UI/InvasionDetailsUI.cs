#region Header
//   Vorspire    _,-'/-'/  InvasionDetailsUI.cs
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
using System.Linq;

using Server.Gumps;

using VitaNex.Schedules;
using VitaNex.SuperGumps;
#endregion

namespace Server.Invasions
{
	public sealed class InvasionDetailsUI : SuperGumpList<Defender>
	{
		public Invasion Invasion { get; private set; }

		public bool OrderAscending { get; set; }

		public bool Expanded { get; set; }

		public InvasionDetailsUI(Mobile user, Gump parent, Invasion invasion)
			: base(user, parent)
		{
			Invasion = invasion;

			CanClose = true;
			CanDispose = true;
			CanMove = true;
			CanResize = true;

			ForceRecompile = true;
			Sorted = true;
		}

		protected override bool OnBeforeSend()
		{
			return base.OnBeforeSend() && Invasion != null && Invasion.Enabled;
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

		protected override void CompileList(List<Defender> list)
		{
			list.Clear();
			list.AddRange(Invasion.Defenders);
			list.RemoveAll(o => o == null || !o.IsValid);

			base.CompileList(list);
		}

		public override int SortCompare(Defender a, Defender b)
		{
			var res = 0;

			if (a.CompareNull(b, ref res))
			{
				return res;
			}

			res = a.CompareTo(b);

			return OrderAscending ? -res : res;
		}

		protected override void CompileLayout(SuperGumpLayout layout)
		{
			base.CompileLayout(layout);

			var hOff = Invasion.Schedule.Enabled || User.AccessLevel >= InvasionService.Access ? 25 : 0;

			var width = Expanded ? 700 : 350;
			var height = 515 + hOff;

			var sup = SupportsUltimaStore;
			var ec = IsEnhancedClient;
			var pad = ec || sup ? 15 : 10;
			var bgID = ec ? 83 : sup ? 40000 : 9270;
			var bgCol = !ec && sup ? Color.FromArgb(255, 41, 49, 57) : Color.Black;

			var tp = new Rectangle2D(0, 0, width, pad * 3);
			var mp = new Rectangle2D(0, tp.Height, width, height - ((tp.Height * 2) + pad + hOff));
			var bp = new Rectangle2D(0, tp.Height + mp.Height, width, height - (tp.Height + mp.Height));

			layout.Add(
				"bg",
				() =>
				{
					AddBackground(0, 0, width, height, bgID);

					AddBackground(tp.X, tp.Y, tp.Width, tp.Height, bgID); // Title
					AddBackground(mp.X, mp.Y, mp.Width, mp.Height, bgID); // Middle Panel
					AddBackground(bp.X, bp.Y, bp.Width, bp.Height, bgID); // Bottom Panel
				});

			layout.Add(
				"title",
				() =>
				{
					var title = "Invasion";

					if (!String.IsNullOrWhiteSpace(Invasion.Name))
					{
						title = Invasion.Name;
					}

					if (!String.IsNullOrWhiteSpace(Invasion.Region))
					{
						title += " at " + Invasion.Region;
					}

					title += String.Format(" [{0}]", Invasion.Status);

					title = title.WrapUOHtmlColor(Color.Gold, false);

					var tx = tp.X + pad;
					var ty = tp.Y + pad;
					var tw = tp.Width - (pad * 2);
					var th = tp.Height - (pad * 2);

					var cw = th * 3;

					AddHtml(tx, ty, tw - cw, th, title, false, false);

					tx += tw - cw;
					tw -= tw - cw;

					tw /= 3;

					AddHtmlButton(tx, ty, tw, th, Order, "\u266F".WrapUOHtmlCenter(), Color.Silver, Color.Silver);

					tx += tw;

					AddHtmlButton(tx, ty, tw, th, Expand, "\u25B2".WrapUOHtmlCenter(), Color.Gold, Color.Gold);

					tx += tw;

					AddHtmlButton(tx, ty, tw, th, Close, "\u203B".WrapUOHtmlCenter(), Color.IndianRed, Color.IndianRed);
				});

			layout.Add(
				"levels",
				() =>
				{
					var x = mp.X + pad;
					var y = mp.Y + pad;
					var w = mp.Width - (pad * 2);
					var h = mp.Height - (pad * 2);

					string label;

					if (!Invasion.IsRunning && Invasion.Started > DateTime.MinValue)
					{
						var format = Expanded ? "d M y t@h:m@ Z" : "m/d/y t@h:m@ Z";
						var time = Invasion.Started.ToSimpleString(format);

						label = String.Format("Defender Ranks [{0}]", time);
					}
					else
					{
						label = "Defender Ranks";
					}

					label = label.WrapUOHtmlCenter();
					label = label.WrapUOHtmlColor(Color.Gold, false);

					AddHtml(x, y, w, 40, label, false, false);

					y += 20;
					h -= 20;

					var range = GetListRange();

					foreach (var o in range)
					{
						CompileEntryLayout(o.Key, x, y, w, 30, o.Value);

						y += 30;
						h -= 30;
					}

					range.Clear();

					y += h - 30;
					h = 30;

					CompileEntryLayout(-1, x, y, w, h, null);

					y -= 30;
					h = 30;

					AddRectangle(x, y, w, 2, Color.White, true);

					y += 2;
					h -= 2;

					w /= 2;

					label = "PREV";
					label = label.WrapUOHtmlCenter();

					if (HasPrevPage)
					{
						AddHtmlButton(x, y, w, h, PreviousPage, label, Color.White, bgCol);
					}
					else
					{
						label = label.WrapUOHtmlColor(Color.Gray, false);

						AddRectangle(x, y, w, h, bgCol, true);
						AddHtml(x + 5, y + 5, w - 12, 40, label, false, false);
					}

					x += w;

					label = "NEXT";
					label = label.WrapUOHtmlCenter();

					if (HasNextPage)
					{
						AddHtmlButton(x, y, w, h, NextPage, label, Color.White, bgCol);
					}
					else
					{
						label = label.WrapUOHtmlColor(Color.Gray, false);

						AddRectangle(x, y, w, h, bgCol, true);
						AddHtml(x + 5, y + 5, w - 12, 40, label, false, false);
					}
				});

			layout.Add(
				"status",
				() =>
				{
					var x = bp.X + pad;
					var y = bp.Y + pad;
					var w = bp.Width - (pad * 2);
					var h = bp.Height - (pad * 2);

					var sx = x + 5;
					var sy = y + 5 + (h - hOff);

					string l;
					int cw;

					if (!Invasion.IsRunning || Invasion.Level == null)
					{
						int spawns = 0, kills = 0;
						var time = 0.0;

						foreach (var o in Invasion.Levels.Where(o => o.IsValid && o.Enabled && o.Spawn.Any(s => s.IsValid && s.Enabled)))
						{
							spawns += o.SpawnAmount;
							kills += o.KillAmount;
							time += o.TimeLimit.TotalSeconds;
						}

						var c = spawns > 0;
						var k = kills > 0;
						var t = time > 0;

						if (!c && !k && !t)
						{
							return;
						}

						cw = w / ((c ? 1 : 0) + (k ? 1 : 0) + (t ? 1 : 0));

						if (c)
						{
							l = String.Format("{0:#,0}", spawns);

							if (Expanded)
							{
								l = String.Format("Invaders: {0}", l);
							}

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddRectangle(x + 5, y, cw - 10, h - hOff, bgCol, Color.White, 1);
							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(1011352); // Creatures

							x += cw;
						}

						if (k)
						{
							l = String.Format("{0:#,0}", kills);

							if (Expanded)
							{
								l = String.Format("Kills: {0}", l);
							}

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddRectangle(x + 5, y, cw - 10, h - hOff, bgCol, Color.White, 1);
							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(1115981); // Kills

							x += cw;
						}

						if (t)
						{
							l = TimeSpan.FromSeconds(time).ToSimpleString(@"<!d\d !>h:m:s");

							if (Expanded)
							{
								l = String.Format("Time: {0}", l);
							}

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddRectangle(x + 5, y, cw - 10, h - hOff, bgCol, Color.White, 1);
							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(3000159); // Time
						}
					}
					else
					{
						var dc = Invasion.Invaders.Count > 0;
						var dk = Invasion.Level.KillAmount > 0;
						var dt = Invasion.Level.TimeLimit > TimeSpan.Zero;

						if (!Expanded && !dc && !dk && !dt)
						{
							return;
						}

						cw = w / ((Expanded ? 1 : 0) + (dc ? 1 : 0) + (dk ? 1 : 0) + (dt ? 1 : 0));

						if (Expanded)
						{
							l = String.IsNullOrWhiteSpace(Invasion.Level.Name)
								? ("Level " + (Invasion.Levels.IndexOf(Invasion.Level) + 1))
								: Invasion.Level.Name;
							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddRectangle(x + 5, y, cw - 10, h - hOff, bgCol, Color.White, 1);
							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);

							x += cw;
						}

						if (dc)
						{
							l = String.Format("{0:#,0}", Invasion.Invaders.Count);

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddRectangle(x + 5, y, cw - 10, h - hOff, bgCol, Color.White, 1);
							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(1011352); // Creatures

							x += cw;
						}

						if (dk)
						{
							var a = Invasion.Kills;
							var b = (double)Invasion.Level.KillAmount;

							AddProgress(x + 5, y, cw - 10, h - hOff, a / b, Direction.Left, Color.Blue, bgCol, Color.White, 1);

							l = String.Format("{0:#,0} / {1:#,0}", a, b);

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(1115981); // Kills

							x += cw;
						}

						if (dt)
						{
							var a = DateTime.UtcNow.Subtract(Invasion.Updated).TotalSeconds;
							var b = Invasion.Level.TimeLimit.TotalSeconds;

							AddProgress(x + 5, y, cw - 10, h - hOff, a / b, Direction.Left, Color.Green, bgCol, Color.White, 1);

							l = TimeSpan.FromSeconds(b - a).ToSimpleString(@"<!d\d !>h:m:s");

							if (!Expanded)
							{
								l = l.WrapUOHtmlSmall();
							}

							l = l.WrapUOHtmlCenter().WrapUOHtmlColor(Color.White, false);

							AddHtml(x + 10, y + 5, cw - 20, 40, l, false, false);
							AddTooltip(3000159); // Time
						}
					}

					if (hOff > 0)
					{
						l = String.Empty;

						if (Invasion.Schedule.NextGlobalTick != null)
						{
							var next = Invasion.Schedule.NextGlobalTick.Value;
							var now = next.Kind == DateTimeKind.Local ? DateTime.Now : DateTime.UtcNow;
							var wait = TimeSpan.FromTicks(Math.Max(0, (next - now).Ticks));
							
							l += "Next: ";
							l += wait.ToSimpleString(@"!<d\d ><h\h ><m\m >s\s");
							l += " - ";
						}

						l += "View Schedule";
						l = l.WrapUOHtmlCenter();

						AddHtmlButton(
							sx,
							sy,
							w - 10,
							20,
							b => Send(new ScheduleOverviewGump(User, Invasion.Schedule, Refresh())),
							l,
							Color.Gold,
							bgCol,
							Color.White,
							1);
					}
				});
		}

		private void CompileEntryLayout(int i, int x, int y, int w, int h, Defender o)
		{
			var sup = SupportsUltimaStore;
			var bgCol = sup ? Color.FromArgb(255, 41, 49, 57) : Color.Black;
			var col = Color.White;

			if (i < 0)
			{
				AddRectangle(x, y, w, 2, col, true);

				y += 2;
				h -= 2;

				if (o == null)
				{
					o = List.Find(d => d.IsValid && d.Mobile == User);
				}

				if (o != null)
				{
					i = List.IndexOf(o);
				}
			}

			if (o != null)
			{
				var r = i + 1;

				if (OrderAscending)
				{
					r = (List.Count - r) + 1;
				}

				switch (r)
				{
					case 1:
						col = Color.PaleGoldenrod;
						break;
					case 2:
						col = Color.Gold;
						break;
					case 3:
						col = Color.Goldenrod;
						break;
				}

				var ox = x;
				var ow = w;

				var cw = ow / 2;

				var label = r.ToString("#,0");

				if (Expanded)
				{
					label = label.WrapUOHtmlBig();
				}

				label = label.WrapUOHtmlColor(col, false);

				AddHtml(x + 5, y + 4, 40, 40, label, false, false);
				AddTooltip(3000563); // Rank

				ox += 50;

				label = o.Mobile.Name;

				if (Expanded)
				{
					label = o.Mobile.GetFullName(false);

					AddImage(ox, y, 0x7557); // 28x28
					AddTooltip(3000547); // Player

					ox += 30;
				}

				if (!Expanded)
				{
					label = label.WrapUOHtmlSmall();
				}

				label = label.WrapUOHtmlColor(User.GetNotorietyColor(o.Mobile), false);

				AddHtml(ox + 5, y + 4, (cw - (ox - x)) - 10, 40, label, false, false);
				AddTooltip(3000547); // Player

				ox = x + cw;
				ow = cw;

				if (Expanded)
				{
					cw = (ow / 3) - 30;

					label = o.Kills.ToString("#,0");
					label = label.WrapUOHtmlColor(col, false);

					AddImage(ox, y, 0x7544); // 28x28
					AddTooltip(1115981); // Kills

					ox += 30;
					ow -= 30;

					AddHtml(ox + 5, y + 4, cw - 10, 40, label, false, false);
					AddTooltip(1115981); // Kills

					ox += cw;
					ow -= cw;

					label = o.Damage.ToString("#,0");
					label = label.WrapUOHtmlColor(col, false);

					AddImage(ox, y, 0x7541); // 28x28
					AddTooltip(1017319); // Damage

					ox += 30;
					ow -= 30;

					AddHtml(ox, y + 4, cw, 40, label, false, false);
					AddTooltip(1017319); // Damage

					ox += cw;
					ow -= cw;
				}

				label = o.Score.ToString("#,0");

				if (!Expanded)
				{
					label = label.WrapUOHtmlSmall();
				}

				label = label.WrapUOHtmlColor(col, false);

				if (Expanded)
				{
					AddImage(ox, y, 0x753F); // 28x28
					AddTooltip(1078503); // Score

					ox += 30;
					ow -= 30;
				}

				AddHtml(ox, y + 4, ow, 40, label, false, false);
				AddTooltip(1078503); // Score
			}
			else if (i < 0)
			{
				var label = "Defeat the invaders to score points!";

				label = label.WrapUOHtmlCenter();

				if (!Expanded)
				{
					label = label.WrapUOHtmlSmall();
				}

				label = label.WrapUOHtmlColor(Color.SkyBlue, false);

				AddHtml(x + 2, y + 4, w - 4, 40, label, false, false);
			}

			AddRectangle(x, y + (h - 2), w, 2, bgCol, true);
		}

		private void Expand(GumpButton b)
		{
			Expand();
		}

		public void Expand()
		{
			Expanded = !Expanded;

			Refresh(true);
		}

		private void Order(GumpButton b)
		{
			Order();
		}

		public void Order()
		{
			OrderAscending = !OrderAscending;

			Refresh(true);
		}
	}
}