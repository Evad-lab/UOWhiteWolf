#region Header
//   Vorspire    _,-'/-'/  LootEntry.cs
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

using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class LootEntry : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public ItemTypeSelectProperty Type { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Amount { get; set; }

		[CommandProperty(InvasionService.Access)]
		public double Chance { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool Unique { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Type.IsNotNull && Amount > 0; } }

		public LootEntry()
		{
			Type = new ItemTypeSelectProperty();

			ClearOptions();
		}

		public LootEntry(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public LootEntry Clone()
		{
			var o = new LootEntry
			{
				Type = Type.InternalType,
				Amount = Amount,
				Chance = Chance,
				Unique = Unique
			};

			return o;
		}

		public void ClearOptions()
		{
			Type = String.Empty;

			Amount = 1;
			Chance = 0;
			Unique = true;
		}

		public override void Clear()
		{
			ClearOptions();
		}

		public override void Reset()
		{
			ClearOptions();
		}

		public Item CreateInstance()
		{
			if (IsValid)
			{
				return Type.CreateInstance();
			}

			return null;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(1);

			writer.WriteType(Type);
			writer.Write(Amount);
			writer.Write(Chance);
			writer.Write(Unique);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			var v = reader.GetVersion();

			Type = reader.ReadType();
			Amount = reader.ReadInt();

			if (v > 0)
			{
				Chance = reader.ReadDouble();
				Unique = reader.ReadBool();
			}
			else
			{
				Chance = reader.ReadInt();
				Chance /= 100.0;

				Unique = true;
			}
		}
	}
}