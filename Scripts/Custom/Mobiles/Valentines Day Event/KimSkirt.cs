using System;
using Server.Items;

namespace Server.Items
{
    public class KimSkirt : BaseArmor
    {
        public override int BasePhysicalResistance { get { return 7; } }
        public override int BaseFireResistance { get { return 8; } }
        public override int BaseColdResistance { get { return 7; } }
        public override int BasePoisonResistance { get { return 7; } }
        public override int BaseEnergyResistance { get { return 7; } }

        public override int InitMinHits { get { return 200; } }
        public override int InitMaxHits { get { return 200; } }

        public override int AosStrReq { get { return 25; } }
        public override int OldStrReq { get { return 10; } }

        public override int ArmorBase { get { return 13; } }

        public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Leather; } }
        public override CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }

        public override ArmorMeditationAllowance DefMedAllowance { get { return ArmorMeditationAllowance.All; } }

        public override bool AllowMaleWearer { get { return true; } }

        public override int LabelNumber { get { return 1109631; } } // Skirt of the White Wolf

        [Constructable]
        public KimSkirt()
            : base(0x7827)
        {
            this.Hue = 1153;			
			this.Weight = 1;

            this.Attributes.BonusInt = 1;
            this.Attributes.LowerRegCost = 10;

            this.SetAttributes.LowerManaCost = 5;
            this.SetAttributes.LowerRegCost = 10;
			Attributes.BonusDex = 8;
            Attributes.NightSight = 1;
            Attributes.AttackChance = 15;
            SkillBonuses.Skill_1_Name = SkillName.Archery;
            SkillBonuses.Skill_1_Value = 20;
        }

        public KimSkirt(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}