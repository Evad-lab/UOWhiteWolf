#region Header
//   Vorspire    _,-'/-'/  Spawn.cs
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

using Server.Items;
using Server.Mobiles;

using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class Spawn : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public bool Enabled { get; set; }

		[CommandProperty(InvasionService.Access)]
		public CreatureTypeSelectProperty Type { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Name { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Title { get; set; }

		[CommandProperty(InvasionService.Access)]
		public AIType AI { get; set; }

		[CommandProperty(InvasionService.Access)]
		public FightMode FightMode { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int FightRange { get; set; }

		[Body, CommandProperty(InvasionService.Access)]
		public Body Body { get; set; }

		[Body, CommandProperty(InvasionService.Access)]
		public int BodyValue { get { return Body.BodyID; } set { Body = value; } }

		[CommandProperty(InvasionService.Access)]
		public int Sound { get; set; }

		[Hue, CommandProperty(InvasionService.Access)]
		public int Hue { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Kills { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Fame { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Karma { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Str { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Dex { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Int { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Hits { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Stam { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Mana { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int DamageMin { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int DamageMax { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Team { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<LootEntry> Loot { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<ItemEntry> Items { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Type.IsNotNull; } }

		public Spawn()
		{
			Loot = new List<LootEntry>();
			Items = new List<ItemEntry>();

			ClearOptions();
		}

		public Spawn(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public Spawn Clone()
		{
			var o = new Spawn
			{
				Enabled = Enabled,
				Type = Type.InternalType,
				Name = Name,
				Title = Title,
				AI = AI,
				FightMode = FightMode,
				FightRange = FightRange,
				Body = Body,
				Sound = Sound,
				Hue = Hue,
				Kills = Kills,
				Fame = Fame,
				Karma = Karma,
				Str = Str,
				Dex = Dex,
				Int = Int,
				Hits = Hits,
				Stam = Stam,
				Mana = Mana,
				DamageMin = DamageMin,
				DamageMax = DamageMax,
				Team = Team
			};

			o.Loot.Clear();

			foreach (var e in Loot)
			{
				o.Loot.Add(e.Clone());
			}

			o.Items.Clear();

			foreach (var e in Items)
			{
				o.Items.Add(e.Clone());
			}

			return o;
		}

		public bool IsType(BaseCreature m)
		{
			return Type.IsNotNull && m != null && m.TypeEquals(Type.InternalType, false);
		}

		public void ClearLoot()
		{
			Loot.Clear();
		}

		public void ClearItems()
		{
			Items.Clear();
		}

		public void ClearOptions()
		{
			Enabled = false;

			Type = String.Empty;

			Name = String.Empty;
			Title = String.Empty;

			AI = AIType.AI_Use_Default;

			FightMode = FightMode.None;
			FightRange = 0;

			Body = 0;

			Sound = Hue = 0;

			Kills = Fame = Karma = 0;

			Str = Dex = Int = 0;
			Hits = Stam = Mana = 0;

			DamageMin = DamageMax = 0;
		}

		public override void Clear()
		{
			ClearLoot();
			ClearItems();
			ClearOptions();
		}

		public override void Reset()
		{
			ClearLoot();
			ClearItems();
			ClearOptions();
		}

		public LootEntry AddLoot(Type type)
		{
			if (type != null)
			{
				return AddLoot(type.FullName);
			}

			return null;
		}

		public LootEntry AddLoot(string type)
		{
			if (String.IsNullOrWhiteSpace(type))
			{
				return null;
			}

			var entry = new LootEntry
			{
				Type = type
			};

			if (entry.IsValid)
			{
				Loot.Add(entry);

				return entry;
			}

			return null;
		}

		public bool RemoveLoot(Type type)
		{
			return Loot.RemoveAll(e => e.Type == type) > 0;
		}

		public bool RemoveLoot(LootEntry entry)
		{
			return Loot.Remove(entry);
		}

		public ItemEntry AddItem(Type type)
		{
			if (type != null)
			{
				return AddItem(type.FullName);
			}

			return null;
		}

		public ItemEntry AddItem(string type)
		{
			if (String.IsNullOrWhiteSpace(type))
			{
				return null;
			}

			var entry = new ItemEntry
			{
				Type = type
			};

			if (entry.IsValid)
			{
				Items.Add(entry);

				return entry;
			}

			return null;
		}

		public bool RemoveItem(Type type)
		{
			return Items.RemoveAll(e => e.Type == type) > 0;
		}

		public bool RemoveItem(ItemEntry entry)
		{
			return Items.Remove(entry);
		}

		public BaseCreature CreateInstance()
		{
			if (!Enabled && !IsValid)
			{
				return null;
			}

			var m = Type.CreateInstance();

			if (m == null)
			{
				return null;
			}

			if (!String.IsNullOrWhiteSpace(Name))
			{
				m.Name = Name;
			}

			if (!String.IsNullOrWhiteSpace(Title))
			{
				m.Title = Title;
			}

			if (AI != AIType.AI_Use_Default)
			{
				m.AI = AI;
			}

			if (FightMode != FightMode.None)
			{
				m.FightMode = FightMode;
			}

			if (FightRange > 0)
			{
				m.RangeFight = FightRange;
			}

			if (!Body.IsEmpty)
			{
				m.Body = Body;
			}

			if (Sound > 0)
			{
				m.BaseSoundID = Sound;
			}

			if (Hue > 0)
			{
				m.Hue = Hue;
			}

			if (Kills > 0)
			{
				m.Kills = Kills;
			}

			if (Fame != 0)
			{
				m.Fame = Fame;
			}

			if (Karma != 0)
			{
				m.Karma = Karma;
			}

			if (Str > 0)
			{
				m.RawStr = Str;
			}

			if (Dex > 0)
			{
				m.RawDex = Dex;
			}

			if (Int > 0)
			{
				m.RawInt = Int;
			}

			if (Hits > 0)
			{
				m.Hits = m.HitsMaxSeed = Hits;
			}

			if (Stam > 0)
			{
				m.Stam = m.StamMaxSeed = Stam;
			}

			if (Mana > 0)
			{
				m.Mana = m.ManaMaxSeed = Mana;
			}

			if (DamageMin > 0)
			{
				m.DamageMin = DamageMin;
			}

			if (DamageMax > 0)
			{
				m.DamageMax = DamageMax;
			}

			if (m.DamageMin > m.DamageMax)
			{
				var value = m.DamageMin;

				m.DamageMin = m.DamageMax;
				m.DamageMax = value;
			}

			if (Team > 0)
			{
				m.Team = Team;
			}

			if (Items.Count > 0)
			{
				Item item;

				foreach (var o in Items.Where(o => o.IsValid && o.Enabled))
				{
					item = o.CreateInstance();

					if (item == null)
					{
						continue;
					}

					if (item.Layer.IsEquip())
					{
						m.AddItem(item);
					}
					else
					{
						var pack = m.Backpack;

						if (pack == null)
						{
							m.AddItem(pack = new Backpack());
						}

						pack.DropItem(item);
					}

					if (item.RootParent != m)
					{
						item.Delete();
					}
				}
			}

			return m;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);

			writer.Write(Enabled);

			writer.WriteType(Type);

			writer.Write(Name);
			writer.Write(Title);

			writer.WriteFlag(AI);

			writer.WriteFlag(FightMode);
			writer.Write(FightRange);

			writer.Write(Body);

			writer.Write(Sound);
			writer.Write(Hue);

			writer.Write(Kills);
			writer.Write(Fame);
			writer.Write(Karma);

			writer.Write(Str);
			writer.Write(Dex);
			writer.Write(Int);

			writer.Write(Hits);
			writer.Write(Stam);
			writer.Write(Mana);

			writer.Write(DamageMin);
			writer.Write(DamageMax);

			writer.Write(Team);

			writer.WriteBlockList(Loot, (w, o) => o.Serialize(w));
			writer.WriteBlockList(Items, (w, o) => o.Serialize(w));
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			Enabled = reader.ReadBool();

			Type = reader.ReadType();

			Name = reader.ReadString();
			Title = reader.ReadString();

			AI = reader.ReadFlag<AIType>();

			FightMode = reader.ReadFlag<FightMode>();
			FightRange = reader.ReadInt();

			Body = reader.ReadInt();

			Sound = reader.ReadInt();
			Hue = reader.ReadInt();

			Kills = reader.ReadInt();
			Fame = reader.ReadInt();
			Karma = reader.ReadInt();

			Str = reader.ReadInt();
			Dex = reader.ReadInt();
			Int = reader.ReadInt();

			Hits = reader.ReadInt();
			Stam = reader.ReadInt();
			Mana = reader.ReadInt();

			DamageMin = reader.ReadInt();
			DamageMax = reader.ReadInt();

			Team = reader.ReadInt();

			Loot = reader.ReadBlockList(r => new LootEntry(r), Loot);
			Items = reader.ReadBlockList(r => new ItemEntry(r), Items);
		}
	}
}