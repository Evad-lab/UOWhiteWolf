#region Header
//   Vorspire    _,-'/-'/  InvasionService_Init.cs
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
using System.Linq;

using VitaNex;
using VitaNex.IO;
#endregion

namespace Server.Invasions
{
	[CoreService("Invasions", "2.0.0.0", TaskPriority.High)]
	public static partial class InvasionService
	{
		static InvasionService()
		{
			CSOptions = new InvasionsOptions();

			Invasions = new BinaryDataStore<int, Invasion>(VitaNexCore.SavesDirectory + "/Invasions", "Invasions")
			{
				Async = true,
				OnSerialize = SerializeInvasions,
				OnDeserialize = DeserializeInvasions
			};
		}

		private static void CSConfig()
		{
			CommandUtility.Register(
				"Invade",
				AccessLevel.Player,
				e =>
				{
					if (e.Mobile.Map == Map.Felucca)
					{
						var current = Invasions.Values.FirstOrDefault(o => o.Enabled && e.Mobile.InRegion(o.Region));

						if (current != null)
						{
							if (e.Mobile.AccessLevel >= Access)
							{
								current.OpenAdminUI(e.Mobile);
							}

							current.OpenDetailsUI(e.Mobile);

							return;
						}
					}

					new InvasionsUI(e.Mobile).Send();
				});

			CommandUtility.RegisterAlias("Invade", "Invasion");
			CommandUtility.RegisterAlias("Invade", "Invasions");
		}

		private static void CSInvoke()
		{
			foreach (var o in Invasions.Values)
			{
				o.GenerateImage();
			}
		}

		private static void CSSave()
		{
			Invasions.RemoveValueRange(o => o == null);

			Invasions.Export();
		}

		private static void CSLoad()
		{
			Invasions.Import();

			Invasions.RemoveValueRange(o => o == null);
		}

		private static bool SerializeInvasions(GenericWriter writer)
		{
			writer.SetVersion(0);

			writer.WriteBlockDictionary(
				Invasions,
				(w, k, v) =>
				{
					w.Write(k);
					v.Serialize(w);
				});

			return true;
		}

		private static bool DeserializeInvasions(GenericReader reader)
		{
			reader.GetVersion();

			reader.ReadBlockDictionary(
				r =>
				{
					var k = r.ReadInt();
					var v = new Invasion(r);

					return new KeyValuePair<int, Invasion>(k, v);
				},
				Invasions);

			return true;
		}
	}
}