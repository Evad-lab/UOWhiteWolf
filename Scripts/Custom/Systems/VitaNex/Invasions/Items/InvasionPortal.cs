#region Header
//   Vorspire    _,-'/-'/  InvasionPortal.cs
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

using Server.Items;
#endregion

namespace Server.Invasions
{
	public sealed class InvasionPortal : DamageableItem
	{
		private Invasion _Invasion;

		[CommandProperty(AccessLevel.GameMaster)]
		public Invasion Invasion
		{
			get { return _Invasion; }
			set
			{
				if (_Invasion == value)
				{
					return;
				}

				if (_Invasion != null)
				{
					_Invasion.Portals.Remove(this);
				}

				_Invasion = value;

				if (_Invasion != null)
				{
					_Invasion.Portals.AddOrReplace(this);
				}
			}
		}

		public override string DefaultName
		{
			get
			{
				if (_Invasion != null)
				{
					return _Invasion.Name + " Portal";
				}

				return "Invasion Portal";
			}
		}

		public int DefHits
		{
			get
			{
				if (_Invasion != null && _Invasion.PortalHitsMax > 0)
				{
					return Utility.RandomMinMax(_Invasion.PortalHitsMin, _Invasion.PortalHitsMax);
				}

				return Utility.RandomMinMax(1000, 2500);
			}
		}

		[Constructable]
		public InvasionPortal()
			: base(19403, 19343, 8148)
		{
			Hue = 2075;
		}

		public InvasionPortal(Serial serial)
			: base(serial)
		{ }

		public override void OnBeforeSpawn(Point3D location, Map m)
		{
			base.OnBeforeSpawn(location, m);

			if (_Invasion != null)
			{
				Hits = HitsMax = DefHits;
			}
		}

		public override void OnMapChange()
		{
			base.OnMapChange();

			if (!Deleted && Invasion == null && Map != null && Map != Map.Internal && Location != Point3D.Zero)
			{
				var invasions = InvasionService.Invasions.Values;

				Invasion = invasions.FirstOrDefault(o => o.Invading != null && o.Invading.Contains(Location, Map));
			}
		}

		public override void OnLocationChange(Point3D oldLocation)
		{
			base.OnLocationChange(oldLocation);

			if (!Deleted && Invasion == null && Map != null && Map != Map.Internal && Location != Point3D.Zero)
			{
				var invasions = InvasionService.Invasions.Values;

				Invasion = invasions.FirstOrDefault(o => o.Invading != null && o.Invading.Contains(Location, Map));
			}
		}

		public override void OnDamage(int amount, Mobile damager, bool willkill)
		{
			base.OnDamage(amount, damager, willkill);

			if (amount > 0 && damager != null && Invasion != null)
			{
				Invasion.HandleDamage(this, damager, amount);

				if (willkill)
				{
					Invasion.HandleDestroy(this, damager);
				}
			}
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.SetVersion(0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.GetVersion();
		}
	}
}