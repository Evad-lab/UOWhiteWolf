using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(FemaleGargishLeatherLegs))]
    [FlipableAttribute(0x1c08, 0x1c09)]
    public class BloodyReaperSkirt : BaseArmor
    {
        [Constructable]
        public BloodyReaperSkirt()
            : base(0x1C08)
        {
            Weight = 1.0;
			Name = "Skirt of the Bloody Reaper";
			Attributes.SpellDamage = 10;
			Attributes.DefendChance = 10;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 12;
			Attributes.BonusMana = 6;
			Attributes.BonusDex = 12;
			Attributes.BonusStr = 8;
			Attributes.BonusInt = 8;
			Attributes.BonusStr = 8;
			Attributes.BonusStam = 8;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.EnhancePotions = 8;
			Attributes.LowerManaCost = 8;
			Attributes.LowerRegCost = 10;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 8;
			Attributes.RegenStam = 8;
			Attributes.RegenMana = 8;
			//ArmorAttributes.SelfRepair = 2;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 115;
			ColdBonus = 10;
			EnergyBonus = 10;
			FireBonus = 9;
			PoisonBonus = 10;
			PhysicalBonus = 11;
			Hue = 2500;
			
			SkillBonuses.SetValues( 1, SkillName.Parry, 10.0 );
        }

        public BloodyReaperSkirt(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BaseFireResistance
        {
            get
            {
                return 4;
            }
        }
        public override int BaseColdResistance
        {
            get
            {
                return 3;
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
                return 3;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 255;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 255;
            }
        }
        public override int AosStrReq
        {
            get
            {
                return 20;
            }
        }
        public override int OldStrReq
        {
            get
            {
                return 10;
            }
        }
        public override int ArmorBase
        {
            get
            {
                return 13;
            }
        }
        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Leather;
            }
        }
        public override CraftResource DefaultResource
        {
            get
            {
                return CraftResource.RegularLeather;
            }
        }
        public override ArmorMeditationAllowance DefMedAllowance
        {
            get
            {
                return ArmorMeditationAllowance.All;
            }
        }
        public override bool AllowMaleWearer
        {
            get
            {
                return false;
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