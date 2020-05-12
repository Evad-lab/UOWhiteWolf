using System;

namespace Server.Items
{
    public class PlateHelmCrimsonDoom : BaseArmor
    {
        [Constructable]
        public PlateHelmCrimsonDoom()
            : base(0x1412)
        {
            Weight = 5.0;
			Name = "Plate Helm of Crimson Doom";
			Attributes.SpellDamage = 15;
			Attributes.DefendChance = 10;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 18;
			Attributes.BonusMana = 18;
			Attributes.BonusStam = 18;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 7;
			Attributes.RegenStam = 7;
			Attributes.RegenMana = 7;
			ArmorAttributes.SelfRepair = 5;
			ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 250;
			ColdBonus = 8;
			EnergyBonus = 8;
			FireBonus = 8;
			PoisonBonus = 8;
			PhysicalBonus = 8;
			Hue = 2117;
        }

        public PlateHelmCrimsonDoom(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance
        {
            get
            {
                return 5;
            }
        }
        public override int BaseFireResistance
        {
            get
            {
                return 3;
            }
        }
        public override int BaseColdResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BasePoisonResistance
        {
            get
            {
                return 3;
            }
        }
        public override int BaseEnergyResistance
        {
            get
            {
                return 2;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 50;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 65;
            }
        }
        public override int AosStrReq
        {
            get
            {
                return 80;
            }
        }
        public override int OldStrReq
        {
            get
            {
                return 40;
            }
        }
        public override int OldDexBonus
        {
            get
            {
                return -1;
            }
        }
        public override int ArmorBase
        {
            get
            {
                return 40;
            }
        }
        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Plate;
            }
        }
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