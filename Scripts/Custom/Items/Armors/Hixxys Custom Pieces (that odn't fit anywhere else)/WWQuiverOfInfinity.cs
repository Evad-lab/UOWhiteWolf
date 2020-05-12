using System;
using Server;

namespace Server.Items
{
    public class WWQuiverOfInfinity : BaseQuiver
	{

        [Constructable]
        public WWQuiverOfInfinity()
            : base(0x2B02)
        {
            LootType = LootType.Blessed;
            Weight = 8.0;
            WeightReduction = 30;
            LowerAmmoCost = 100;
            Attributes.DefendChance = 10;
			Name = "White Wolf's Quiver of Infinity";
			//Attributes.SpellDamage = 15;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 10;
			Attributes.BonusStam = 10;
			//Attributes.BonusStr = 15;
			Attributes.CastRecovery = 4;
			Attributes.CastSpeed = 4;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 15;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 3;
			Attributes.RegenStam = 2;
			Attributes.RegenMana = 3;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 100;
			//ColdBonus = 8;
			//EnergyBonus = 8;
			//FireBonus = 8;
			//PoisonBonus = 8;
			//PhysicalBonus = 8;
			Resistances.Cold = 5;
			Resistances.Energy = 5;
			Resistances.Fire = 5;
			Resistances.Physical = 5;
			Resistances.Poison = 5;
			
			SkillBonuses.SetValues( 1, SkillName.Archery, 10.0 );
			//SkillBonuses.SetValues( 2, SkillName.Carpentry, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.Mining, 5.0 );
			//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
			Hue = 1153;
			
        }

        public WWQuiverOfInfinity(Serial serial)
            : base(serial)
        {
        }

		public override bool CanAlter
		{
			get
			{
				return false;
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(2); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            if (version < 1 && this.DamageIncrease == 0)
                this.DamageIncrease = 10;

            if (version < 2 && this.Attributes.WeaponDamage == 10)
                this.Attributes.WeaponDamage = 0;
        }
    }
}