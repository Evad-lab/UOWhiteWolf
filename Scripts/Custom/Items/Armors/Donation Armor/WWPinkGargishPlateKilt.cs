using System;

namespace Server.Items
{
    [TypeAlias("Server.Items.MaleGargishPlateKilt")]
    public class WWPinkGargishPlateKilt : BaseArmor
    {
        [Constructable]
        public WWPinkGargishPlateKilt()
            : this(0)
        {
        }

        [Constructable]
        public WWPinkGargishPlateKilt(int hue)
            : base(0x30C)
        {
            Weight = 5.0;
            Hue = 1166;
			LootType = LootType.Blessed;
			Name = "†--I'm a True White Wolf Kilt--†";
			Attributes.SpellDamage = 50;
			Attributes.DefendChance = 15;
			Attributes.AttackChance = 40;
			Attributes.WeaponSpeed = 10;
			Attributes.BonusHits = 45;
			Attributes.BonusMana = 45;
			Attributes.BonusStam = 35;
			Attributes.BonusStr = 35;
			Attributes.BonusDex = 45;
			Attributes.BonusInt = 35;
			Attributes.CastRecovery = 6;
			Attributes.CastSpeed = 6;
			Attributes.LowerManaCost = 20;
			Attributes.LowerRegCost = 35;
			Attributes.ReflectPhysical = 25;
			Attributes.EnhancePotions = 15;
			Attributes.RegenHits = 20;
			Attributes.RegenStam = 20;
			Attributes.RegenMana = 20;
			//ArmorAttributes.SelfRepair = 5;
			ArmorAttributes.MageArmor = 1;
			Attributes.NightSight = 1;
			Attributes.Luck = 666;
			ColdBonus = 15;
			EnergyBonus = 15;
			FireBonus = 14;
			PoisonBonus = 14;
			PhysicalBonus = 12;
			
			SkillBonuses.SetValues( 1, SkillName.Healing, 15.0 );
			//SkillBonuses.SetValues( 2, SkillName.Fletching, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			//SetVaues( 4, SkillName.Mining, 5.0 );
			//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
        }

        public WWPinkGargishPlateKilt(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance { get { return 8; } }
        public override int BaseFireResistance { get { return 6; } }
        public override int BaseColdResistance { get { return 5; } }
        public override int BasePoisonResistance { get { return 6; } }
        public override int BaseEnergyResistance { get { return 5; } }

        public override int InitMinHits { get { return 0; } }
        public override int InitMaxHits { get { return 0; } }

        public override int AosStrReq { get { return 80; } }

        public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Plate; } }

        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}