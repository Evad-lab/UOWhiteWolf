#region Header
//   Vorspire    _,-'/-'/  Defender.cs
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

using Server.Mobiles;

using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class Defender : PropertyObject, IComparable<Defender>
	{
		[CommandProperty(InvasionService.Access)]
		public PlayerMobile Mobile { get; private set; }

		[CommandProperty(InvasionService.Access)]
		public double Damage { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Kills { get; set; }

		[CommandProperty(InvasionService.Access)]
		public int Points { get; set; }

		[CommandProperty(InvasionService.Access)]
		public double Score
		{
			get
			{
				var score = 0.0;

				if (Points > 0)
				{
					score += Points;
				}

				if (Damage > 0)
				{
					score += Damage * 0.337;
				}

				return score * 100.0;
			}
		}

		[CommandProperty(InvasionService.Access)]
		public bool IsValid { get { return Mobile != null; } }

		public Defender(PlayerMobile m)
		{
			Mobile = m;

			SetDefaults();
		}

		public Defender(GenericReader reader)
			: base(reader)
		{ }

		public void SetDefaults()
		{
			Points = 0;
			Damage = 0;
			Kills = 0;
		}

		public override void Clear()
		{
			SetDefaults();
		}

		public override void Reset()
		{
			SetDefaults();
		}

		public int CompareTo(Defender d)
		{
			var res = 0;

			if (this.CompareNull(d, ref res))
			{
				return res;
			}

			var x = Score;
			var y = d.Score;

			if (x > y)
			{
				return -1;
			}

			if (x < y)
			{
				return 1;
			}

			x = Damage;
			y = d.Damage;

			if (x > y)
			{
				return -1;
			}

			if (x < y)
			{
				return 1;
			}

			x = Kills;
			y = d.Kills;

			if (x > y)
			{
				return -1;
			}

			if (x < y)
			{
				return 1;
			}

			return 0;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			var v = writer.SetVersion(2);

			writer.Write(Mobile);
			writer.Write(Damage);
			writer.Write(Kills);

			if (v > 0)
			{
				writer.Write(Points);
			}
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			var v = reader.GetVersion();

			Mobile = reader.ReadMobile<PlayerMobile>();
			Damage = reader.ReadDouble();
			Kills = reader.ReadInt();

			if (v > 0)
			{
				Points = v > 1 ? reader.ReadInt() : (int)reader.ReadDouble();
			}
		}
	}
}