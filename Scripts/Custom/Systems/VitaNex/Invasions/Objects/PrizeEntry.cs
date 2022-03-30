#region Header
//   Vorspire    _,-'/-'/  PrizeEntry.cs
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
	public sealed class PrizeEntry : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public ItemTypeSelectProperty Type { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Amount { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Type.IsNotNull && Amount > 0; } }

		public PrizeEntry()
		{
			Type = new ItemTypeSelectProperty();

			ClearOptions();
		}

		public PrizeEntry(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public PrizeEntry Clone()
		{
			var o = new PrizeEntry
			{
				Type = Type.InternalType,
				Amount = Amount
			};

			return o;
		}

		public void ClearOptions()
		{
			Type = String.Empty;

			Amount = 1;
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

			writer.SetVersion(0);

			writer.WriteType(Type);
			writer.Write(Amount);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			Type = reader.ReadType();
			Amount = reader.ReadInt();
		}
	}
}