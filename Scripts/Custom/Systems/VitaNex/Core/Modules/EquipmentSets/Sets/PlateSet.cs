#region Header
//   Vorspire    _,-'/-'/  PlateSet.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2016  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using Server;
using Server.Items;
#endregion

namespace VitaNex.Modules.EquipmentSets
{
	public sealed class PlateArmorSet : EquipmentSet
	{
		public PlateArmorSet()
			: base("Plate Avenger")
		{
			/*Add Parts to this Set*/
			Add(new EquipmentSetPart("Avenger's Chestguard", typeof(PlateChest)));
			Add(new EquipmentSetPart("Avenger's Pauldrons", typeof(PlateArms)));
			Add(new EquipmentSetPart("Avenger's Gauntlets", typeof(PlateGloves)));
			Add(new EquipmentSetPart("Avenger's Neckguard", typeof(PlateGorget)));
			Add(new EquipmentSetPart("Avenger's Legguards", typeof(PlateLegs)));
			Add(new EquipmentSetPart("Avenger's Helmet", typeof(PlateHelm)));

			/*Add Mods to this Set*/
			Add(new StatOffsetSetMod("PlateAvenger1", "Avenger I", 2, true, StatType.All, 1));
			Add(new StatOffsetSetMod("PlateAvenger2", "Avenger II", 4, true, StatType.All, 1));
			Add(new StatOffsetSetMod("PlateAvenger3", "Avenger III", 6, true, StatType.All, 1));
		}
	}
}