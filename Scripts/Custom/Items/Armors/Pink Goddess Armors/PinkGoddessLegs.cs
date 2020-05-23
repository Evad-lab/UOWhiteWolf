using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(GargishLeatherLegs))]
    [FlipableAttribute(0x13cb, 0x13d2)]
    public class PinkGoddessLegs : BaseArmor
    {
        [Constructable]
        public PinkGoddessLegs()
            : base(0x13CB)
        {
            this.Weight = 4.0;
			Name = "Leggings of the Pink Goddess";
			Attributes.SpellDamage = 10;
			Attributes.DefendChance = 5;
			Attributes.AttackChance = 5;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 10;
			Attributes.BonusDex = 10;
			Attributes.BonusInt = 6;
			Attributes.BonusStr = 8;
			Attributes.BonusStam = 6;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;
			//Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 5;
			Attributes.RegenStam = 5;
			Attributes.RegenMana = 5;
			//ArmorAttributes.SelfRepair = 2;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 100;
			ColdBonus = 17;
			EnergyBonus = 17;
			FireBonus = 16;
			PoisonBonus = 17;
			PhysicalBonus = 18;
			Hue = 14;
			
			SkillBonuses.SetValues( 1, SkillName.Magery, 5.0 );
        }

        public PinkGoddessLegs(Serial serial)
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