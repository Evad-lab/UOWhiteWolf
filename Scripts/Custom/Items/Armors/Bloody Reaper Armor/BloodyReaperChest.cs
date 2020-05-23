using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(GargishLeatherChest))]
    [FlipableAttribute(0x13cc, 0x13d3)]
    public class BloodyReaperChest : BaseArmor
    {
        [Constructable]
        public BloodyReaperChest()
            : base(0x13CC)
        {
            Weight = 6.0;
			Name = "Chest of the Bloody Reaper";
			Attributes.SpellDamage = 10;
			Attributes.DefendChance = 5;
			Attributes.AttackChance = 5;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 6;
			Attributes.BonusDex = 10;
			Attributes.BonusInt = 8;
			Attributes.BonusStr = 8;
			Attributes.BonusStam = 15;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.LowerManaCost = 5;
			Attributes.LowerRegCost = 15;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 6;
			Attributes.RegenStam = 6;
			Attributes.RegenMana = 6;
			//ArmorAttributes.SelfRepair = 2;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 75;
			ColdBonus = 14;
			EnergyBonus = 14;
			FireBonus = 13;
			PoisonBonus = 14;
			PhysicalBonus = 15;
			Hue = 33;
			
			SkillBonuses.SetValues( 1, SkillName.Parry, 5.0 );
        }

        public BloodyReaperChest(Serial serial)
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
                return 25;
            }
        }
        public override int OldStrReq
        {
            get
            {
                return 15;
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