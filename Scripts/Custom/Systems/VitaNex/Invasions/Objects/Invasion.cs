#region Header
//   Vorspire    _,-'/-'/  Invasion.cs
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
using System.Drawing.Imaging;
using System.Linq;

using Server.Items;
using Server.Mobiles;
using Server.Regions;

using VitaNex;
using VitaNex.Collections;
using VitaNex.IO;
using VitaNex.Schedules;
using VitaNex.SuperGumps;
#endregion

namespace Server.Invasions
{
	public sealed class Invasion : PropertyObject, ICloneable
	{
		private static int _UID = 1;

		private static readonly PrizeEntry[] _DefPrizes =
		{
			//
			// Added to any newly created invasion
			// Number of prizes = number of default ranks (one prize per rank)
			new PrizeEntry
			{
				Type = typeof(Gold),
				Amount = 50000
			},
			new PrizeEntry
			{
				Type = typeof(Gold),
				Amount = 25000
			},
			new PrizeEntry
			{
				Type = typeof(Gold),
				Amount = 10000
			}
		};

		private static readonly ListPool<LootEntry> _LootPool = new ListPool<LootEntry>();
		private static readonly ListPool<PlayerMobile> _PlayerPool = new ListPool<PlayerMobile>();

		public static void GiveLoot(BaseCreature invader, List<LootEntry> loot)
		{
			if (invader == null || loot == null || loot.Count == 0)
			{
				return;
			}

			var unique = _LootPool.Acquire();
			var killers = _PlayerPool.Acquire();

			var rights = invader.GetLootingRights();

			killers.AddRange(rights.OrderByDescending(o => o.m_Damage).Select(o => o.m_Mobile).OfType<PlayerMobile>());
			killers.Prune(true);

			rights.Free(true);

			LootEntry entry;
			Item item;
			int amount;

			foreach (var m in killers)
			{
				var index = loot.Count;

				while (--index >= 0)
				{
					if (!loot.InBounds(index))
					{
						continue;
					}

					entry = loot[index];

					if (!entry.IsValid || entry.Chance <= 0 || entry.Amount <= 0)
					{
						continue;
					}

					if (entry.Unique && unique.Contains(entry))
					{
						continue;
					}

					if (Utility.RandomDouble() > entry.Chance)
					{
						continue;
					}

					if (entry.Unique)
					{
						unique.AddOrReplace(entry);
					}

					item = entry.CreateInstance();

					if (item == null)
					{
						continue;
					}

					amount = entry.Amount;

					while (amount > 0)
					{
						if (item == null)
						{
							item = entry.CreateInstance();
						}

						if (item.Stackable)
						{
							item.Amount = Math.Max(1, Math.Min(60000, amount));
						}

						amount -= item.Amount;

						if (m != null && m.Player && item.GiveTo(m, GiveFlags.PackFeetDelete, amount <= 0).WasReceived())
						{
							item = null;
						}

						if (item == null)
						{
							continue;
						}

						item.Delete();
						item = null;
					}
				}
			}

			_LootPool.Free(unique);
			_PlayerPool.Free(killers);
		}

		public static void GivePrizes(Mobile m, List<PrizeEntry> prizes)
		{
			if (m == null || !m.Player || prizes == null || prizes.Count == 0)
			{
				return;
			}

			PrizeEntry entry;
			Item item;
			int amount;

			var index = prizes.Count;

			while (--index >= 0)
			{
				if (!prizes.InBounds(index))
				{
					continue;
				}

				entry = prizes[index];

				if (!entry.IsValid || entry.Amount <= 0)
				{
					continue;
				}

				item = entry.CreateInstance();

				if (item == null)
				{
					continue;
				}

				amount = entry.Amount;

				while (amount > 0)
				{
					if (item == null)
					{
						item = entry.CreateInstance();
					}

					if (item.Stackable)
					{
						item.Amount = Math.Max(1, Math.Min(60000, amount));
					}

					amount -= item.Amount;

					item.GiveTo(m, GiveFlags.PackFeetDelete, amount <= 0);

					item = null;
				}
			}
		}

		private static Point3D GetRandomPoint3D(
			IPoint3D start,
			int minRange,
			int maxRange,
			Map map,
			bool checkLOS,
			bool checkSpawn)
		{
			if ((map == null || map == Map.Internal) && start is IEntity)
			{
				map = ((IEntity)start).Map;
			}

			double a, r;
			int x, y;
			Point3D s, p;

			var c = 10;

			do
			{
				a = Utility.RandomDouble() * Math.PI * 2;
				r = minRange + (Math.Sqrt(Utility.RandomDouble()) * (maxRange - minRange));

				x = (int)(r * Math.Cos(a));
				y = (int)(r * Math.Sin(a));

				s = start.Clone3D(0, 0, 16);
				p = start.Clone3D(x, y);

				if (map != null)
				{
					p = p.GetSurfaceTop(map);
				}

				if (map == null || ((!checkLOS || map.LineOfSight(s, p)) && (!checkSpawn || map.CanSpawnMobile(p))))
				{
					break;
				}
			}
			while (--c >= 0);

			if (c >= 0)
			{
				return p;
			}

			if (map != null)
			{
				return start.GetSurfaceTop(map);
			}

			return start.ToPoint3D();
		}

		private static bool IsInside(IPoint2D p, int z, Map map)
		{
			if (p == null || map == null || map == Map.Internal)
			{
				return false;
			}

			if (p is Item)
			{
				z += Math.Max(0, ((Item)p).ItemData.Height) + 1;
			}

			z = Math.Max(Server.Region.MinZ, Math.Min(Server.Region.MaxZ, z));

			return !map.CanFit(p.X, p.Y, z, Server.Region.MaxZ - z, true, false, false);
		}

		private static bool IsOutside(IPoint2D p, int z, Map map)
		{
			return !IsInside(p, z, map);
		}

		public List<SuperGump> Gumps { get; private set; }

		[CommandProperty(InvasionService.Access, true)]
		public int UID { get; private set; }

		[CommandProperty(InvasionService.Access)]
		public bool Enabled { get; set; }

		[CommandProperty(InvasionService.Access)]
		public string Name
		{
			get { return _Name; }
			set
			{
				_Name = value;

				if (Schedule != null && _Name != null)
				{
					Schedule.Name = _Name;
				}
			}
		}

		[CommandProperty(InvasionService.Access)]
		public string Region { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool UseGates { get; set; }

		[CommandProperty(InvasionService.Access, true)]
		public DateTime Started { get; private set; }

		[CommandProperty(InvasionService.Access, true)]
		public DateTime Updated { get; private set; }

		[CommandProperty(InvasionService.Access, true)]
		public InvasionStatus Status { get; private set; }

		[CommandProperty(InvasionService.Access)]
		public int Kills { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int GoldPool { get; set; }

		[CommandProperty(InvasionService.Access, true)]
		public Level Level { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<Moongate> TownGates { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<BaseCreature> Invaders { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<InvasionPortal> Portals { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PortalCount { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PortalHitsMin { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int PortalHitsMax { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<Defender> Defenders { get; set; }

		[CommandProperty(InvasionService.Access)]
		public SpawnArea SpawnZone { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<Level> Levels { get; set; }

		[CommandProperty(InvasionService.Access)]
		public List<Rank> Ranks { get; set; }

		[CommandProperty(InvasionService.Access)]
		public bool RankPrizes { get; set; }

		[CommandProperty(InvasionService.Access)]
		public Schedule Schedule { get; set; }

		public bool IsWaiting { get { return Status == InvasionStatus.Waiting; } }
		public bool IsRunning { get { return Status == InvasionStatus.Running; } }
		public bool IsFinished { get { return Status == InvasionStatus.Finished; } }

		private int _CoreTicks;
		private PollTimer _CoreTimer;

		private Region _Region;
		private bool _RegionWasGuarded;
		private string _Name;

		[CommandProperty(InvasionService.Access)]
		public Region Invading { get { return _Region; } }

		[CommandProperty(InvasionService.Access)]
		public Map Map { get; set; }

		public Invasion()
			: this(false)
		{ }

		private Invasion(bool clone)
		{
			while (InvasionService.Invasions.ContainsKey(_UID))
			{
				++_UID;
			}

			UID = _UID;

			Gumps = new List<SuperGump>();
			TownGates = new List<Moongate>();
			Invaders = new List<BaseCreature>();
			Portals = new List<InvasionPortal>();
			Defenders = new List<Defender>();

			Levels = new List<Level>();
			Ranks = new List<Rank>();

			if (!clone)
			{
				Levels.Add(
					new Level
					{
						Enabled = false,
						KillAmount = 1000,
						SpawnAmount = 100,
						TimeLimit = TimeSpan.FromHours(1.0),
						Spawn =
						{
							new Spawn
							{
								Enabled = false,
								Type = typeof(Mongbat)
							}
						}
					});

				for (var i = 0; i < _DefPrizes.Length; i++)
				{
					Ranks.Add(
						new Rank
						{
							Enabled = false,
							Place = i + 1,
							Prizes =
							{
								_DefPrizes[i]
							}
						});
				}
			}

			Name = "Invasion " + UID;

			if (!clone)
			{
				Schedule = new Schedule(Name, false, ScheduleMonths.All, ScheduleDays.Sunday, null, ScheduledStart);
			}

			Map = Map.Felucca;
			Region = "Britain";

			UseGates = true;
			GoldPool = 10000;
			PortalCount = 10;

			InvasionService.Invasions[UID] = this;

			if (!clone)
			{
				InitTimer();
			}
		}

		public Invasion(GenericReader reader)
			: base(reader)
		{ }

		object ICloneable.Clone()
		{
			return Clone();
		}

		public Invasion Clone()
		{
			var o = new Invasion(true)
			{
				Enabled = false,
				Name = Name + " Clone",
				Region = Region,
				UseGates = UseGates,
				GoldPool = GoldPool,
				PortalCount = PortalCount,
				PortalHitsMin = PortalHitsMin,
				PortalHitsMax = PortalHitsMax,
				RankPrizes = RankPrizes
			};
			
			if(_Region != null && SpawnZone != null)
			{
				o.SpawnZone = SpawnArea.Instantiate(_Region, TileFlag.Roof | TileFlag.Wet, null, true);
			}

			o.Levels.Clear();

			foreach (var e in Levels)
			{
				o.Levels.Add(e.Clone());
			}

			o.Ranks.Clear();

			foreach (var e in Ranks)
			{
				o.Ranks.Add(e.Clone());
			}

			var info = new ScheduleInfo(Schedule.Info.Months, Schedule.Info.Days, new ScheduleTimes(Schedule.Info.Times));

			o.Schedule = new Schedule(Schedule.Name, Schedule.Enabled, info);

			o.Schedule.OnGlobalTick += o.ScheduledStart;

			o.InitTimer();

			return o;
		}

		public void GenerateImage()
		{
			if (SpawnZone == null || SpawnZone.Count == 0)
			{
				return;
			}

			var path = IOUtility.GetSafeFilePath("web/invasions/" + UID + ".png", true);

			IOUtility.EnsureDirectory(path);

			SpawnZone.Image.Save(path, ImageFormat.Png);
		}

		public void OpenAdminUI(Mobile m)
		{
			if (m != null)
			{
				var ui = Gumps.OfType<InvasionEditUI>().FirstOrDefault(g => g.User == m);

				(ui ?? new InvasionEditUI(m, null, this)).Refresh(true);
			}
		}

		public void OpenDetailsUI(Mobile m)
		{
			if (m != null)
			{
				var ui = Gumps.OfType<InvasionDetailsUI>().FirstOrDefault(g => g.User == m);

				(ui ?? new InvasionDetailsUI(m, null, this)).Refresh(true);
			}
		}

		public void RefreshDetailsUI(Mobile m)
		{
			if (m != null)
			{
				var ui = Gumps.OfType<InvasionDetailsUI>().FirstOrDefault(g => g.User == m);

				if (ui != null)
				{
					ui.Refresh(true);
				}
			}
		}

		public void CloseDetailsUI(Mobile m)
		{
			if (m != null)
			{
				var ui = Gumps.OfType<InvasionDetailsUI>().FirstOrDefault(g => g.User == m && !g.IsDisposed);

				if (ui != null)
				{
					ui.Close();
				}
			}
		}

		public void CloseAdminUI()
		{
			CloseUI(true, false);
		}

		public void CloseDetailsUI()
		{
			CloseUI(false, true);
		}

		public void CloseUI()
		{
			CloseUI(true, true);
		}

		private void CloseUI(bool admin, bool deets)
		{
			if (!admin && !deets)
			{
				return;
			}

			Gumps.ForEachReverse(
				g =>
				{
					if ((admin && (g is InvasionEditUI || g is LevelEditUI || g is SpawnEditUI || g is RankEditUI)) ||
						(deets && g is InvasionDetailsUI))
					{
						g.Close(true);
					}
				});
		}

		public void RefreshAdminUI()
		{
			RefreshUI(true, false);
		}

		public void RefreshDetailsUI()
		{
			RefreshUI(false, true);
		}

		public void RefreshUI()
		{
			RefreshUI(true, true);
		}

		private void RefreshUI(bool admin, bool deets)
		{
			if (!admin && !deets)
			{
				return;
			}

			Gumps.ForEachReverse(
				g =>
				{
					if ((admin && (g is InvasionEditUI || g is LevelEditUI || g is SpawnEditUI || g is RankEditUI)) ||
						(deets && g is InvasionDetailsUI))
					{
						g.Refresh(true);
					}
				});
		}

		private void InitTimer()
		{
			if (_CoreTimer == null)
			{
				_CoreTimer = PollTimer.FromSeconds(1.0, Slice, () => Enabled && IsRunning);
			}
			else
			{
				_CoreTimer.Start();
			}

			if (Schedule != null)
			{
				Schedule.Running = true;
			}
		}

		private void Slice()
		{
			++_CoreTicks;

			var next = false;
			var cancel = false;

			if (Level == null || !Level.IsValid || !Level.Enabled || !Level.Spawn.Any(s => s.IsValid && s.Enabled))
			{
				next = true;
			}
			else
			{
				if (Level.TimeLimit > TimeSpan.Zero)
				{
					next = cancel = DateTime.UtcNow >= Updated.Add(Level.TimeLimit);
				}

				if (Kills >= Level.KillAmount)
				{
					next = true;
					cancel = false;
				}
			}

			var end = false;

			if (!DeltaRegion(ref _Region))
			{
				end = Stop(true);
			}
			else if (SpawnZone == null)
			{
				SpawnZone = SpawnArea.Instantiate(_Region, TileFlag.Roof | TileFlag.Wet, null, true);
			}
			else if (next)
			{
				if (cancel || !NextLevel(Level))
				{
					end = Stop(cancel);
				}
			}
			else
			{
				if (_CoreTicks % 30 == 0) // 30 secs
				{
					SpawnPortals();
				}

				if (_CoreTicks % 10 == 0) // 10 secs
				{
					SpawnInvaders();
				}

				if (_CoreTicks % 1800 == 0) // 30 mins
				{
					World.Broadcast(33, false, "[Invasion]: Defenders are needed at {0} to halt {1}!", Region, Name);
				}
			}

			if (end || _CoreTicks % 10 == 0)
			{
				InvalidateGuards();
				InvalidateGates();
				RefreshDetailsUI();
			}
		}

		private void ScheduledStart(Schedule s)
		{
			string status;

			if (!Start(out status))
			{
				var now = s.CurrentGlobalTick ?? DateTime.UtcNow;

				String.Format("[{0}]: Scheduled Invasion '{1}' at '{2}' could not start:\n{3}", now, Name, Region, status)
					  .Log("Invasions.log");
			}
		}

		public bool CanStart(out string status)
		{
			status = String.Empty;

			if (!Enabled)
			{
				status = "Invasion is currently disabled.";
				return false;
			}

			if (IsRunning)
			{
				status = "Invasion is currently running.";
				return false;
			}

			if (String.IsNullOrWhiteSpace(Name))
			{
				status = "Invasion Name is invalid or empty.";
				return false;
			}

			if (String.IsNullOrWhiteSpace(Region))
			{
				status = "Target Region Name is invalid or empty.";
				return false;
			}

			if (!DeltaRegion(ref _Region))
			{
				status = "Target Region does not exist.";
				return false;
			}

			if (!Levels.Any(o => o.IsValid && o.Enabled && o.Spawn.Any(s => s.IsValid && s.Enabled)))
			{
				status = "No valid or enabled level was found.";
				return false;
			}

			return true;
		}

		public bool Start()
		{
			string status;

			return Start(out status);
		}

		public bool Start(out string status)
		{
			if (!CanStart(out status))
			{
				return false;
			}

			Reset();

			if (!DeltaRegion(ref _Region))
			{
				status = "Invasion Region does not exist.";
				return false;
			}

			if (SpawnZone == null)
			{
				SpawnZone = SpawnArea.Instantiate(_Region, TileFlag.Roof | TileFlag.Wet, null, true);
			}

			if (SpawnZone == null || SpawnZone.Count == 0)
			{
				status = "No valid spawn locations could be generated.";
				return false;
			}

			Level = Levels.FirstOrDefault(o => o.IsValid && o.Enabled && o.Spawn.Any(s => s.IsValid && s.Enabled));

			if (Level == null)
			{
				status = "No valid or enabled level was found.";
				return false;
			}

			Started = Updated = DateTime.UtcNow;

			Status = InvasionStatus.Running;

			InvalidateGuards();
			InvalidateGates();

			World.Broadcast(33, false, "[Invasion]: Defenders are needed at {0} to halt {1}!", Region, Name);

			RefreshUI();

			InvasionService.InvokeStarted(this);

			status = String.Empty;
			return true;
		}

		public bool Stop(bool cancel)
		{
			string status;

			return Stop(cancel, out status);
		}

		public bool Stop(bool cancel, out string status)
		{
			if (!IsRunning)
			{
				status = "Invasion is currently not running.";
				return true;
			}

			Status = InvasionStatus.Finished;

			DeleteInvaders();
			DeletePortals();

			InvalidateGuards(true);
			InvalidateGates();

			Defenders.Sort();

			World.Broadcast(33, false, "[Invasion]: The {0} assault at {1} has been halted!", Name, Region);

			RefreshUI();

			if (!cancel)
			{
				var i = 0;

				const string format =
					"[Invasion]: {0} has achieved rank #{1:#,0} with {2:#,0} point{3}, {4:#,0} kill{5} and {6:#,0} damage done.";

				foreach (var o in Defenders)
				{
					OpenDetailsUI(o.Mobile);

					if (++i <= 3)
					{
						switch (i)
						{
							case 1:
								o.Mobile.SendMessage("You have achieved first place in defending the invasion!");
								break;
							case 2:
								o.Mobile.SendMessage("You have achieved second place in defending the invasion!");
								break;
							case 3:
								o.Mobile.SendMessage("You have achieved third place in defending the invasion!");
								break;
						}

						World.Broadcast(
							33,
							false,
							format,
							o.Mobile.RawName,
							i,
							o.Score,
							o.Score != 1 ? "s" : String.Empty,
							o.Kills,
							o.Kills != 1 ? "s" : String.Empty,
							o.Damage);
					}

					if (RankPrizes)
					{
						foreach (var rank in Ranks.Where(r => r.IsValid && r.Enabled && r.Place == i))
						{
							GivePrizes(o.Mobile, rank.Prizes);
						}
					}
				}
			}

			GiveScoreRewards();

			InvasionService.InvokeFinished(this);

			status = String.Empty;
			return true;
		}

		private void GiveScoreRewards()
		{
			if (Defenders.IsNullOrEmpty())
			{
				return;
			}

			var total = Defenders.Sum(o => o.Score);

			foreach (var d in Defenders)
			{
				GiveScoreRewards(d.Mobile, d.Score / total);
			}
		}

		private void GiveScoreRewards(Mobile m, double factor)
		{
			// factor: % contributed towards score total for all defenders

			if (GoldPool > 0)
			{
				var gold = (int)(GoldPool * factor);

				if (gold > 0 && Banker.Deposit(m, gold))
				{
					m.SendMessage("{0:#,0} Gold has been credited to your bank for your efforts in halting the invasion!", gold);
				}
			}
			/*
			if (factor >= 0.95)
			{ }
			else if (factor >= 0.90)
			{ }
			else if (factor >= 0.75)
			{ }
			else if (factor >= 0.50)
			{ }
			else if (factor >= 0.10)
			{ }
			else
			{ }
			*/
		}

		public void Delete()
		{
			if (_CoreTimer == null)
			{
				return;
			}

			Status = InvasionStatus.Waiting;

			_CoreTimer.Stop();
			_CoreTimer = null;

			Clear();

			CloseUI();

			Gumps.Clear();

			InvasionService.Invasions.Remove(UID);
		}

		public override void Reset()
		{
			DeleteInvaders();
			DeletePortals();
			DeleteGates();

			Defenders.Clear();

			Started = DateTime.MinValue;
			Updated = DateTime.MinValue;

			_CoreTicks = 0;
			Kills = 0;

			Level = null;

			_Region = null;
		}

		public override void Clear()
		{
			DeleteInvaders();
			DeletePortals();
			DeleteGates();

			ClearLevels();
			ClearRanks();

			Defenders.Clear();

			SpawnZone = null;

			Started = DateTime.MinValue;
			Updated = DateTime.MinValue;

			_CoreTicks = 0;
			Kills = 0;

			Level = null;

			_Region = null;
		}

		public void ClearRanks()
		{
			Ranks.Clear();
		}

		public Rank AddRank()
		{
			var place = 0;

			do
			{
				++place;
			}
			while (Ranks.Any(r => r.Place == place));

			var rank = new Rank
			{
				Place = place
			};

			if (rank.IsValid)
			{
				Ranks.Add(rank);

				return rank;
			}

			return null;
		}

		public bool RemoveRank(Rank entry)
		{
			if (Ranks.Remove(entry))
			{
				return true;
			}

			return false;
		}

		public void ClearLevels()
		{
			Levels.Clear();
		}

		public Level AddLevel()
		{
			var level = new Level();

			if (level.IsValid)
			{
				Levels.Add(level);

				return level;
			}

			return null;
		}

		public bool RemoveLevel(Level entry)
		{
			if (Levels.Remove(entry))
			{
				return true;
			}

			return false;
		}

		private bool NextLevel(Level last)
		{
			if (Levels.Count == 0)
			{
				return false;
			}

			var index = Levels.IndexOf(last) + 1;

			if (!Levels.InBounds(index))
			{
				return false;
			}

			var next = Levels[index];

			if (!next.IsValid || !next.Enabled || !next.Spawn.Any(o => o.IsValid && o.Enabled))
			{
				return NextLevel(next);
			}

			DeleteInvaders();

			Updated = DateTime.UtcNow;

			_CoreTicks = 0;
			Kills = 0;

			Level = next;

			InvasionService.InvokeLevelChanged(this, last);

			RefreshDetailsUI();

			return true;
		}

		public void InvalidateGuards()
		{
			InvalidateGuards(false);
		}

		public void InvalidateGuards(bool delayed)
		{
			if (!DeltaRegion(ref _Region))
			{
				_RegionWasGuarded = false;
				return;
			}

			var r = _Region.GetRegion<GuardedRegion>();

			if (r == null)
			{
				_RegionWasGuarded = false;
				return;
			}

			if (IsRunning)
			{
				if (!r.Disabled)
				{
					_RegionWasGuarded = r.Disabled = true;
				}
			}
			else if (_RegionWasGuarded)
			{
				if (delayed)
				{
					Timer.DelayCall(TimeSpan.FromMinutes(5.0), v => _RegionWasGuarded = r.Disabled = v, false);

					const string msg = "The Guards will be back from their break soon!";

					foreach (var m in r.GetPlayers())
					{
						if ((m.Kills >= 5 && !r.AllowReds) || m.Criminal)
						{
							m.SendNotification(msg + " You have about 5 minutes to get out of here!", color: Color.IndianRed);
						}
						else
						{
							m.SendNotification(msg + " You have about 5 minutes to clean up any criminals!", color: Color.IndianRed);
						}
					}
				}
				else
				{
					_RegionWasGuarded = r.Disabled = false;
				}
			}
		}

		public void InvalidateGates()
		{
			if (!IsRunning || !UseGates)
			{
				DeleteGates();
				return;
			}

			if (TownGates.IsNullOrEmpty())
			{
				SpawnGates();
			}
		}

		public void SpawnGates()
		{
			DeleteGates();

			if (!UseGates || SpawnZone == null || SpawnZone.Count == 0)
			{
				return;
			}

			var points = new[]
			{
				new Point3D(1427, 1701, 0), new Point3D(2512, 564, 0), new Point3D(2717, 2173, 0), new Point3D(2237, 1195, 0),
				new Point3D(4453, 1166, 0), new Point3D(1821, 2819, 0), new Point3D(2895, 689, 0)
			};

			foreach (var p in points)
			{
				var loc = p;
				var idx = 50;

				while (!Map.CanFit(loc, 16, true, false) && --idx >= 0)
				{
					loc = GetRandomPoint3D(loc, 2, 4, Map, false, false);
				}

				if (idx < 0)
				{
					continue;
				}

				var g = new Moongate(false)
				{
					Name = String.Format("{0} Invasion at {1}", Name, Region),
					Hue = 1172,
					Dispellable = false,
					TargetMap = Map,
					Target = SpawnZone.GetRandom()
				};

				TownGates.Add(g);

				g.MoveToWorld(loc, Map);
			}
		}

		public void DeleteGates()
		{
			TownGates.ForEachReverse(g => g.Delete());
			TownGates.Clear();
		}

		private void SpawnPortals()
		{
			if (SpawnZone == null || SpawnZone.Count == 0)
			{
				return;
			}

			if (Level == null || !Level.IsValid || !Level.Enabled)
			{
				return;
			}

			if (Level.KillAmount > 0 && Kills >= Level.KillAmount)
			{
				return;
			}

			if (!Level.Spawn.Any(o => o.IsValid && o.Enabled))
			{
				return;
			}

			Point3D? p;

			var map = Map;
			var cnt = Math.Max(0, Math.Min(Level.KillAmount - Kills, PortalCount));

			while (Portals.Count < cnt)
			{
				var portal = new InvasionPortal();

				p = SpawnZone.GetRandom();

				portal.SetPropertyValue("Invasion", this);

				portal.OnBeforeSpawn(p.Value, map);
				portal.MoveToWorld(p.Value, map);
				portal.OnAfterSpawn();
			}
		}

		private void SpawnInvaders()
		{
			if (SpawnZone == null || SpawnZone.Count == 0)
			{
				return;
			}

			if (Level == null || !Level.IsValid || !Level.Enabled)
			{
				return;
			}

			if (Level.KillAmount > 0 && Kills >= Level.KillAmount)
			{
				return;
			}

			if (!Level.Spawn.Any(o => o.IsValid && o.Enabled))
			{
				return;
			}

			var count = Level.SpawnAmount - Invaders.Count;

			if (count <= 0)
			{
				return;
			}

			count = Math.Min(100, count);

			Point3D? p;

			var map = Map;

			foreach (var spawn in GenerateSpawnBatch(count))
			{
				p = null;

				if (Portals.Count > 0)
				{
					var o = Portals.GetRandom();

					if (o != null)
					{
						var tries = 10;

						do
						{
							p = GetRandomPoint3D(o, 1, 12, map, false, true);
						}
						while ((p == Point3D.Zero || !IsOutside(p, p.Value.Z, map)) && --tries >= 0);

						if (tries < 0)
						{
							p = null;
						}
					}
				}

				if (p == null || p == Point3D.Zero)
				{
					p = SpawnZone.GetRandom();
				}

				if (p == Point3D.Zero)
				{
					spawn.Delete();
					continue;
				}

				Invaders.AddOrReplace(spawn);

				spawn.Home = p.Value;

				spawn.SetPropertyValue("GuardImmune", true);
				spawn.SetPropertyValue("Invasion", this);

				spawn.OnBeforeSpawn(p.Value, map);
				spawn.MoveToWorld(p.Value, map);
				spawn.OnAfterSpawn();
			}
		}

		private IEnumerable<BaseCreature> GenerateSpawnBatch(int count)
		{
			if (count <= 0)
			{
				yield break;
			}

			Spawn entry = null;
			BaseCreature spawn = null;

			foreach (var s in Level.Spawn.Where(s => s.IsValid && s.Enabled).Randomize())
			{
				spawn = s.CreateInstance();

				if (spawn == null)
				{
					s.Enabled = false;
					continue;
				}

				entry = s;
				break;
			}

			if (entry == null)
			{
				yield break;
			}

			while (--count >= 0)
			{
				if (spawn == null)
				{
					spawn = entry.CreateInstance();
				}

				yield return spawn;

				spawn = null;
			}

			if (spawn != null)
			{
				spawn.Delete();
			}
		}

		public void DeletePortals()
		{
			Portals.ForEachReverse(
				o =>
				{
					o.SetPropertyValue("Invasion", null);
					o.Delete();
				});

			Portals.Clear();
		}

		public void DeleteInvaders()
		{
			Invaders.ForEachReverse(
				o =>
				{
					o.SetPropertyValue("Invasion", null);
					o.Delete();
				});

			Invaders.Clear();
		}

		public bool ValidTarget(IEntity o)
		{
			if (!IsRunning || !DeltaRegion(ref _Region))
			{
				return false;
			}

			if (o is BaseCreature)
			{
				return ValidInvader((BaseCreature)o);
			}

			if (o is InvasionPortal)
			{
				return ValidPortal((InvasionPortal)o);
			}

			return false;
		}

		public bool ValidInvader(BaseCreature invader)
		{
			if (!IsRunning || !DeltaRegion(ref _Region))
			{
				return false;
			}

			if (invader == null || !Invaders.Contains(invader))
			{
				return false;
			}

			if (Level == null || !Level.IsValid || !Level.Enabled)
			{
				return false;
			}

			if (!Level.Spawn.Any(s => s.IsValid && s.Enabled && s.IsType(invader)))
			{
				return false;
			}

			if (Level.KillAmount > 0 && Kills >= Level.KillAmount)
			{
				return false;
			}

			if (Level.TimeLimit > TimeSpan.Zero && Updated.Add(Level.TimeLimit) < DateTime.UtcNow)
			{
				return false;
			}

			return true;
		}

		public bool ValidPortal(InvasionPortal portal)
		{
			if (!IsRunning || !DeltaRegion(ref _Region))
			{
				return false;
			}

			if (portal == null || !Portals.Contains(portal))
			{
				return false;
			}

			return true;
		}

		private Defender EnsureDefender(PlayerMobile m)
		{
			if (m == null)
			{
				return null;
			}

			var def = Defenders.Find(d => d.IsValid && d.Mobile == m);

			if (def != null)
			{
				if (m.Deleted)
				{
					Defenders.Remove(def);

					CloseDetailsUI(m);
				}
			}
			else if (!m.Deleted)
			{
				Defenders.Add(def = new Defender(m));

				OpenDetailsUI(m);
			}

			return def;
		}

		public void HandleDamage(IEntity o, Mobile damager, double damage)
		{
			if (!ValidTarget(o))
			{
				if (o is BaseCreature)
				{
					Timer.DelayCall(m => m.SetPropertyValue("Invasion", null), (BaseCreature)o);
				}
				else if (o is InvasionPortal)
				{
					Timer.DelayCall(p => p.SetPropertyValue("Invasion", null), (InvasionPortal)o);
				}

				return;
			}

			if (damager == null)
			{
				return;
			}

			Mobile master;

			while (damager != null && damager.IsControlled(out master))
			{
				damager = master;
			}

			if (damager == null)
			{
				return;
			}

			var def = EnsureDefender(damager as PlayerMobile);

			if (def != null)
			{
				def.Damage += damage;

				var bonus = 0.0;

				if (Level != null)
				{
					bonus += (Levels.IndexOf(Level) + 1) / (double)Levels.Count(l => l.Enabled && l.IsValid);
				}

				if (o is InvasionPortal && PortalHitsMax > 0)
				{
					bonus += ((InvasionPortal)o).HitsMax / (double)PortalHitsMax;
				}

				if (bonus > 0)
				{
					def.Points += (int)(damage * bonus);
				}
			}
		}

		public void HandleKill(BaseCreature invader, Mobile killer)
		{
			if (!ValidTarget(invader))
			{
				if (invader != null)
				{
					Timer.DelayCall(m => m.SetPropertyValue("Invasion", null), invader);
				}

				return;
			}

			Mobile master;

			while (killer != null && killer.IsControlled(out master))
			{
				killer = master;
			}

			if (killer != null)
			{
				var def = EnsureDefender(killer as PlayerMobile);

				if (def != null)
				{
					++def.Kills;
				}
			}

			++Kills;

			GiveLoot(invader, Level.Loot);

			foreach (var s in Level.Spawn.Where(s => s.IsValid && s.Enabled && s.IsType(invader)))
			{
				GiveLoot(invader, s.Loot);
			}

			Invaders.Remove(invader);

			Timer.DelayCall(m => m.SetPropertyValue("Invasion", null), invader);
		}

		public void HandleDestroy(InvasionPortal portal, Mobile destroyer)
		{
			if (!ValidTarget(portal))
			{
				if (portal != null)
				{
					Timer.DelayCall(p => p.SetPropertyValue("Invasion", null), portal);
				}

				return;
			}

			Mobile master;

			while (destroyer != null && destroyer.IsControlled(out master))
			{
				destroyer = master;
			}

			if (destroyer != null)
			{
				var def = EnsureDefender(destroyer as PlayerMobile);

				if (def != null)
				{
					++def.Kills;
				}
			}

			Portals.Remove(portal);

			Timer.DelayCall(p => p.SetPropertyValue("Invasion", null), portal);
		}

		private bool DeltaRegion(ref Region r)
		{
			if (r != null && r.Name == Region && r.Map == Map)
			{
				return true;
			}

			if (Map != null && Map != Map.Internal)
			{
				var o = r;

				r = Map.Regions.GetValue(Region);

				if (r != null)
				{
					if (o != r)
					{
						SpawnZone = null;
					}

					return true;
				}
			}

			SpawnZone = null;

			return false;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);

			writer.Write(UID);

			writer.Write(Enabled);

			writer.Write(Name);

			writer.Write(Map);
			writer.Write(Region);

			writer.Write(Started);
			writer.WriteDeltaTime(Updated);

			writer.WriteFlag(Status);

			writer.Write(_CoreTicks);

			writer.Write(_RegionWasGuarded);

			writer.Write(Kills);

			writer.Write(GoldPool);

			writer.Write(UseGates);

			writer.WriteItemList(TownGates);
			writer.WriteMobileList(Invaders);

			writer.Write(PortalCount);
			writer.WriteItemList(Portals);

			writer.Write(PortalHitsMin);
			writer.Write(PortalHitsMax);

			writer.WriteBlockList(Defenders, (w, o) => o.Serialize(w));

			writer.WriteBlockList(
				Levels,
				(w, l) =>
				{
					l.Serialize(w);

					w.Write(l == Level);
				});

			writer.Write(RankPrizes);
			writer.WriteBlockList(Ranks, (w, o) => o.Serialize(w));

			Schedule.Serialize(writer);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();

			UID = reader.ReadInt();

			Enabled = reader.ReadBool();

			Name = reader.ReadString();

			Map = reader.ReadMap();
			Region = reader.ReadString();

			Started = reader.ReadDateTime();
			Updated = reader.ReadDeltaTime();

			Status = reader.ReadFlag<InvasionStatus>();

			_CoreTicks = reader.ReadInt();

			_RegionWasGuarded = reader.ReadBool();

			Kills = reader.ReadInt();

			GoldPool = reader.ReadInt();

			UseGates = reader.ReadBool();

			TownGates = reader.ReadStrongItemList<Moongate>();
			Invaders = reader.ReadStrongMobileList<BaseCreature>();

			PortalCount = reader.ReadInt();
			Portals = reader.ReadStrongItemList<InvasionPortal>();

			PortalHitsMin = reader.ReadInt();
			PortalHitsMax = reader.ReadInt();

			Defenders = reader.ReadBlockList(r => new Defender(r), Defenders);

			Levels = reader.ReadBlockList(
				r =>
				{
					var l = new Level(r);

					if (r.ReadBool())
					{
						Level = l;
					}

					return l;
				},
				Levels);

			RankPrizes = reader.ReadBool();
			Ranks = reader.ReadBlockList(r => new Rank(r), Ranks);

			Schedule = new Schedule(reader);

			if (Schedule.Name != Name && Name != null)
			{
				Schedule.Name = Name;
			}

			if (TownGates == null)
			{
				TownGates = new List<Moongate>();
			}

			if (Invaders == null)
			{
				Invaders = new List<BaseCreature>();
			}

			if (Portals == null)
			{
				Portals = new List<InvasionPortal>();
			}

			if (Defenders == null)
			{
				Defenders = new List<Defender>();
			}

			if (Levels == null)
			{
				Levels = new List<Level>();
			}

			if (Level == null)
			{
				Level = Levels.FirstOrDefault();
			}

			if (Gumps == null)
			{
				Gumps = new List<SuperGump>();
			}

			if (Ranks == null)
			{
				Ranks = new List<Rank>();
			}

			Invaders.ForEachReverse(o => o.SetPropertyValue("Invasion", this));
			Portals.ForEachReverse(o => o.SetPropertyValue("Invasion", this));

			if (DeltaRegion(ref _Region))
			{
				SpawnZone = SpawnArea.Instantiate(_Region, TileFlag.Roof | TileFlag.Wet, null, true);
			}

			Schedule.OnGlobalTick += ScheduledStart;

			InitTimer();
		}
	}
}