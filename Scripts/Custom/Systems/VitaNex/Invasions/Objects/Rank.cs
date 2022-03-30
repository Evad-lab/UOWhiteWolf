#region Header
//   Vorspire    _,-'/-'/  Rank.cs
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

using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class Rank : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public bool Enabled { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Name { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Place { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<PrizeEntry> Prizes { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Place > 0; } }

		public Rank()
		{
			Prizes = new List<PrizeEntry>();

			ClearOptions();
		}

		public Rank(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public Rank Clone()
		{
			var o = new Rank
			{
				Enabled = Enabled,
				Name = Name,
				Place = Place
			};

			o.Prizes.Clear();

			foreach (var e in Prizes)
			{
				o.Prizes.Add(e.Clone());
			}

			return o;
		}

		public void ClearPrizes()
		{
			Prizes.Clear();
		}

		public void ClearOptions()
		{
			Enabled = false;

			Place = 0;
		}

		public override void Clear()
		{
			ClearPrizes();
			ClearOptions();
		}

		public override void Reset()
		{
			ClearPrizes();
			ClearOptions();
		}

		public PrizeEntry AddPrize(Type type)
		{
			if (type != null)
			{
				return AddPrize(type.FullName);
			}

			return null;
		}

		public PrizeEntry AddPrize(string type)
		{
			if (String.IsNullOrWhiteSpace(type))
			{
				return null;
			}

			var entry = new PrizeEntry
			{
				Type = type
			};

			if (entry.IsValid)
			{
				Prizes.Add(entry);

				return entry;
			}

			return null;
		}

		public bool RemovePrize(Type type)
		{
			return Prizes.RemoveAll(e => e.Type == type) > 0;
		}

		public bool RemovePrize(PrizeEntry entry)
		{
			return Prizes.Remove(entry);
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);

			writer.Write(Enabled);

			writer.Write(Name);
			writer.Write(Place);

			writer.WriteBlockList(Prizes, (w, o) => o.Serialize(w));
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			Enabled = reader.ReadBool();

			Name = reader.ReadString();
			Place = reader.ReadInt();

			Prizes = reader.ReadBlockList(r => new PrizeEntry(r), Prizes);
		}
	}
}