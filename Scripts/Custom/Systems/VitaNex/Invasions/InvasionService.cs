#region Header
//   Vorspire    _,-'/-'/  InvasionService.cs
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
using System.Linq;

using VitaNex.IO;
#endregion

namespace Server.Invasions
{
	public static partial class InvasionService
	{
		public const AccessLevel Access = AccessLevel.Administrator;

		public static InvasionsOptions CSOptions { get; private set; }

		public static BinaryDataStore<int, Invasion> Invasions { get; private set; }

		public static event Action<Invasion> OnStarted;
		public static event Action<Invasion> OnFinished;
		public static event Action<Invasion, Level> OnLevelChanged;

		public static Invasion GetInvasionByID(int uid)
		{
			return Invasions.GetValue(uid);
		}

		public static Invasion GetInvasionByName(string name)
		{
			return Invasions.Values.FirstOrDefault(o => Insensitive.Equals(o.Name, name));
		}

		public static void InvokeStarted(Invasion o)
		{
			if (OnStarted != null)
			{
				OnStarted(o);
			}
		}

		public static void InvokeFinished(Invasion o)
		{
			if (OnFinished != null)
			{
				OnFinished(o);
			}
		}

		public static void InvokeLevelChanged(Invasion o, Level old)
		{
			if (OnLevelChanged != null)
			{
				OnLevelChanged(o, old);
			}
		}
	}
}