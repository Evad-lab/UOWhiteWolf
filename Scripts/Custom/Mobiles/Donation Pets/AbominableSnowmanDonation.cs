using System;

using Server.Mobiles;
using Server.Items;

namespace Server.Engines.SorcerersDungeon
{
    [CorpseName("an abominable snowmans corpse")]
    public class AbominableSnowmanDonation : BaseCreature
    {
        [Constructable]
        public AbominableSnowmanDonation ()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "the abominable snowman";

            Body = 267;
            BaseSoundID = 367;
            Hue = 2036;

            SetStr(1179);
            SetDex(496);
            SetInt(1200);

            SetHits(1200);

            SetDamage(30, 50);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Cold, 50);

            SetResistance(ResistanceType.Physical, 60, 70);
            SetResistance(ResistanceType.Fire, 40, 50);
            SetResistance(ResistanceType.Cold, 100);
            SetResistance(ResistanceType.Poison, 60, 70);
            SetResistance(ResistanceType.Energy, 60, 70);

            SetSkill(SkillName.Anatomy, 115, 120);
            SetSkill(SkillName.Poisoning, 120);
            SetSkill(SkillName.MagicResist, 115, 120);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 120, 130);
			SetSkill(SkillName.Magery, 72.2, 98.9);
			SetSkill(SkillName.EvalInt, 72.2, 98.9);
			SetSkill(SkillName.Meditation, 72.2, 98.9);

            Fame = 12000;
            Karma = -12000;

            SetWeaponAbility(WeaponAbility.ConcussionBlow);
            SetWeaponAbility(WeaponAbility.CrushingBlow);
            SetSpecialAbility(SpecialAbility.TrueFear);
			SetSpecialAbility(SpecialAbility.LightningForce);
			
			Tamable = true;
            ControlSlotsMax = 5;
			ControlSlotsMin = 4;
			ControlSlots = 4;
            MinTameSkill = 120.1;
			
        }

        public AbominableSnowmanDonation (Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmune { get { return Poison.Deadly; } }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich, 2);
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
