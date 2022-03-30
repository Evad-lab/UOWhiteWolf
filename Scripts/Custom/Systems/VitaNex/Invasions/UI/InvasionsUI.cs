#region Header
//   Vorspire    _,-'/-'/  InvasionsUI.cs
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

using Server.Gumps;

using VitaNex.SuperGumps.UI;
#endregion

namespace Server.Invasions
{
	public sealed class InvasionsUI : ListGump<Invasion>
	{
		public InvasionsUI(Mobile user)
			: base(user, null, null, null, null, "No invasions to display.", "Invasions")
		{
			ForceRecompile = true;
		}

		protected override void CompileMenuOptions(MenuGumpOptions list)
		{
			base.CompileMenuOptions(list);

			list.AppendEntry(new ListGumpEntry("Create Invasion", OnCreateInvasion, HighlightHue));
		}

		private void OnCreateInvasion(GumpButton b)
		{
			var o = new Invasion();

			List.Add(o);

			SelectEntry(b, o);
		}

		protected override void CompileList(List<Invasion> list)
		{
			list.Clear();
			list.AddRange(InvasionService.Invasions.Values);

			if (User.AccessLevel < InvasionService.Access)
			{
				list.RemoveAll(o => !o.Enabled);
			}

			base.CompileList(list);
		}

		protected override int GetLabelHue(int index, int pageIndex, Invasion entry)
		{
			if (entry == null || !entry.Enabled)
			{
				return ErrorHue;
			}

			if (entry.IsRunning)
			{
				return HighlightHue;
			}

			return TextHue;
		}

		protected override string GetLabelText(int index, int pageIndex, Invasion entry)
		{
			if (entry != null)
			{
				var label = String.Empty;

				if (!String.IsNullOrWhiteSpace(entry.Name))
				{
					label += entry.Name;
				}

				if (!String.IsNullOrWhiteSpace(entry.Region))
				{
					label += (label.Length > 0 ? " in " : " ") + entry.Region;
				}

				if (!String.IsNullOrWhiteSpace(label))
				{
					return label;
				}
			}

			return base.GetLabelText(index, pageIndex, entry);
		}

		protected override void SelectEntry(GumpButton button, Invasion entry)
		{
			base.SelectEntry(button, entry);

			if (entry == null)
			{
				Refresh(true);
				return;
			}

			if (User.AccessLevel >= InvasionService.Access)
			{
				var opt = new MenuGumpOptions();

				opt.AppendEntry(new ListGumpEntry("Edit", OnEdit));
				opt.AppendEntry(new ListGumpEntry("Clone", OnClone));
				opt.AppendEntry(new ListGumpEntry("View", OnView));

				Send(new MenuGump(User, Hide(), opt));
			}
			else
			{
				new InvasionDetailsUI(User, Hide(), entry).Send();
			}
		}

		private void OnClone()
		{
			if (Selected == null)
			{
				return;
			}

			var o = Selected.Clone();

			if (o != null)
			{
				Selected = o;

				OnEdit();
			}

			Refresh(true);
		}

		private void OnEdit()
		{
			if (Selected != null)
			{
				new InvasionEditUI(User, Hide(), Selected).Send();
			}
		}

		private void OnView()
		{
			if (Selected != null)
			{
				new InvasionDetailsUI(User, Hide(), Selected).Send();
			}
		}
	}
}