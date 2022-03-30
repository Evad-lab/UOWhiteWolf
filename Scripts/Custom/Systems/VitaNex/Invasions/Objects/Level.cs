#region Header
//   Vorspire    _,-'/-'/  Level.cs
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
	public sealed class Level : PropertyObject, ICloneable
	{
		[CommandProperty(InvasionService.Access)]
		public bool Enabled { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Name { get; set; }

		[CommandProperty(InvasionService.Access)]
		public TimeSpan TimeLimit { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int SpawnAmount { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int KillAmount { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<LootEntry> Loot { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<Spawn> Spawn { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return SpawnAmount > 0 && (KillAmount > 0 || TimeLimit > TimeSpan.Zero); } }

		public Level()
		{
			Loot = new List<LootEntry>();
			Spawn = new List<Spawn>();

			ClearOptions();
		}

		public Level(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public Level Clone()
		{
			var o = new Level
			{
				Enabled = Enabled,
				Name = Name,
				TimeLimit = TimeLimit,
				SpawnAmount = SpawnAmount,
				KillAmount = KillAmount
			};

			o.Loot.Clear();

			foreach (var e in Loot)
			{
				o.Loot.Add(e.Clone());
			}

			o.Spawn.Clear();

			foreach (var e in Spawn)
			{
				o.Spawn.Add(e.Clone());
			}

			return o;
		}

		public void ClearLoot()
		{
			Loot.Clear();
		}

		public void ClearSpawn()
		{
			Spawn.Clear();
		}

		public void ClearOptions()
		{
			Enabled = false;

			TimeLimit = TimeSpan.Zero;

			SpawnAmount = 1;
			KillAmount = 1;
		}

		public override void Clear()
		{
			ClearLoot();
			ClearSpawn();
			ClearOptions();
		}

		public override void Reset()
		{
			ClearLoot();
			ClearSpawn();
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

		public Spawn AddSpawn(Type type)
		{
			if (type != null)
			{
				return AddSpawn(type.FullName);
			}

			return null;
		}

		public Spawn AddSpawn(string type)
		{
			if (String.IsNullOrWhiteSpace(type))
			{
				return null;
			}

			var entry = new Spawn
			{
				Type = type
			};

			if (entry.IsValid)
			{
				Spawn.Add(entry);

				return entry;
			}

			return null;
		}

		public bool RemoveSpawn(Type type)
		{
			return Spawn.RemoveAll(e => e.Type == type) > 0;
		}

		public bool RemoveSpawn(Spawn entry)
		{
			return Spawn.Remove(entry);
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);

			writer.Write(Enabled);

			writer.Write(Name);

			writer.Write(TimeLimit);
			writer.Write(SpawnAmount);
			writer.Write(KillAmount);

			writer.WriteBlockList(Spawn, (w, o) => o.Serialize(w));
			writer.WriteBlockList(Loot, (w, o) => o.Serialize(w));
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			Enabled = reader.ReadBool();

			Name = reader.ReadString();

			TimeLimit = reader.ReadTimeSpan();
			SpawnAmount = reader.ReadInt();
			KillAmount = reader.ReadInt();

			Spawn = reader.ReadBlockList(r => new Spawn(r), Spawn);
			Loot = reader.ReadBlockList(r => new LootEntry(r), Loot);

			if (Spawn == null)
			{
				Spawn = new List<Spawn>();
			}

			if (Loot == null)
			{
				Loot = new List<LootEntry>();
			}
		}
	}
}