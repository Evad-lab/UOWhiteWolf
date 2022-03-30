#region Header
//   Vorspire    _,-'/-'/  InvasionsOptions.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using VitaNex;
#endregion

namespace Server.Invasions
{
	public sealed class InvasionsOptions : CoreServiceOptions
	{
		public InvasionsOptions()
			: base(typeof(InvasionService))
		{
			EnsureDefaults();
		}

		public InvasionsOptions(GenericReader reader)
			: base(reader)
		{ }

		public void EnsureDefaults()
		{ }

		public override void Clear()
		{
			base.Clear();

			EnsureDefaults();
		}

		public override void Reset()
		{
			base.Reset();

			EnsureDefaults();
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