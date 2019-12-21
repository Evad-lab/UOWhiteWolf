#region Header
//   Vorspire    _,-'/-'/  ItemEntry.cs
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

using Server.Items;

using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class ItemEntry : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public bool Enabled { get; set; }

		[CommandProperty(InvasionService.Access)]
		public TypeSelectProperty<Item> Type { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Name { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Hue { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool Movable { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PropCountMin { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PropCountMax { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PropMin { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PropMax { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Type.IsNotNull; } }

		public ItemEntry()
		{
			Type = new ItemTypeSelectProperty();

			ClearOptions();
		}

		public ItemEntry(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public ItemEntry Clone()
		{
			var o = new ItemEntry
			{
				Enabled = Enabled,
				Type = Type.InternalType,
				Name = Name,
				Hue = Hue,
				Movable = Movable,
				PropCountMin = PropCountMin,
				PropCountMax = PropCountMax,
				PropMin = PropMin,
				PropMax = PropMax
			};

			return o;
		}

		public void ClearOptions()
		{
			Enabled = false;

			Type = String.Empty;

			Name = String.Empty;

			Hue = -1;
			Movable = false;

			PropCountMin = PropCountMax = 0;
			PropMin = PropMax = 0;
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
			if (!IsValid)
			{
				return null;
			}

			var item = Type.CreateInstance();

			if (!String.IsNullOrWhiteSpace(Name))
			{
				item.Name = Name;
			}

			if (Hue > -1)
			{
				item.Hue = Hue;
			}

			item.Movable = Movable;

			if ((PropCountMin > 0 || PropCountMax > 0) && (PropMin > 0 || PropMax > 0))
			{
				ApplyAttributes(item, PropCountMin, PropCountMax, PropMin, PropMax, 0);
			}

			return item;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);

			writer.Write(Enabled);

			writer.WriteType(Type);

			writer.Write(Name);

			writer.Write(Hue);
			writer.Write(Movable);

			writer.Write(PropCountMin);
			writer.Write(PropCountMax);
			writer.Write(PropMin);
			writer.Write(PropMax);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			Enabled = reader.ReadBool();

			Type = reader.ReadType();

			Name = reader.ReadString();

			Hue = reader.ReadInt();
			Movable = reader.ReadBool();

			PropCountMin = reader.ReadInt();
			PropCountMax = reader.ReadInt();
			PropMin = reader.ReadInt();
			PropMax = reader.ReadInt();
		}

		private static void ApplyAttributes(
			Item item,
			int minProp,
			int maxProp,
			int minIntensity,
			int maxIntensity,
			int luckLevel)
		{
			if (!Core.AOS)
			{
				return;
			}

			int delta;

			if (minProp > maxProp)
			{
				delta = minProp;
				minProp = maxProp;
				maxProp = delta;
			}

			if (minIntensity > maxIntensity)
			{
				delta = minIntensity;
				minIntensity = maxIntensity;
				maxIntensity = delta;
			}

			var attributeCount = Utility.RandomMinMax(minProp, maxProp);

			ApplyAttributesTo(item, false, luckLevel, attributeCount, minIntensity, maxIntensity);
		}

		private static void ApplyAttributesTo(
			Item item,
			bool isRunicTool,
			int luckChance,
			int attributeCount,
			int min,
			int max)
		{
			if (item is FishingPole)
			{
				BaseRunicTool.ApplyAttributesTo((FishingPole)item, isRunicTool, luckChance, attributeCount, min, max);
			}
			else if (item is BaseWeapon)
			{
				BaseRunicTool.ApplyAttributesTo((BaseWeapon)item, isRunicTool, luckChance, attributeCount, min, max);
			}
			else if (item is BaseArmor)
			{
				BaseRunicTool.ApplyAttributesTo((BaseArmor)item, isRunicTool, luckChance, attributeCount, min, max);
			}
			else if (item is BaseHat)
			{
				BaseRunicTool.ApplyAttributesTo((BaseHat)item, isRunicTool, luckChance, attributeCount, min, max);
			}
			else if (item is BaseJewel)
			{
				BaseRunicTool.ApplyAttributesTo((BaseJewel)item, isRunicTool, luckChance, attributeCount, min, max);
			}
			else if (item is Spellbook)
			{
				BaseRunicTool.ApplyAttributesTo((Spellbook)item, isRunicTool, luckChance, attributeCount, min, max);
			}
		}
	}
}