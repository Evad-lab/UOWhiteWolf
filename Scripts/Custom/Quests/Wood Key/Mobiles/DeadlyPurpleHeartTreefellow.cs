using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a deadly treefellow corpse")]
    public class DeadlyPurpleHeartTreefellow : BaseCreature
    {
        [Constructable]
        public DeadlyPurpleHeartTreefellow()
            : base(AIType.AI_Mystic, FightMode.Evil, 10, 1, 0.2, 0.4)
        {
            Name = "a Deadly Purpleheart Treefellow";
            Body = 301;
			Hue = 114;

            SetStr(700, 895);
            SetDex(30, 55);
            SetInt(403, 491);

            SetHits(1724, 1900);

            SetDamage(25, 40);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 30, 35);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 80, 90);

            SetSkill(SkillName.MagicResist, 40.1, 55.0);
            SetSkill(SkillName.Tactics, 65.1, 90.0);
            SetSkill(SkillName.Wrestling, 65.1, 85.0);
            SetSkill(SkillName.Spellweaving, 120.0);

            Fame = 500;
            Karma = 1500;

            VirtualArmor = 24;
            PackItem(new Log(Utility.RandomMinMax(23, 34)));

            if (0.3 > Utility.RandomDouble())
                PackItem(new FreshPurpleHeartLog());

            SetWeaponAbility(WeaponAbility.Dismount);
        }

        public DeadlyPurpleHeartTreefellow(Serial serial)
            : base(serial)
        {
        }

        public override OppositionGroup OppositionGroup
        {
            get
            {
                return OppositionGroup.FeyAndUndead;
            }
        }
        public override bool BleedImmune
        {
            get
            {
                return true;
            }
        }

        public override int GetIdleSound()
        {
            return 443;
        }

        public override int GetDeathSound()
        {
            return 31;
        }

        public override int GetAttackSound()
        {
            return 672;
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
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

            if (BaseSoundID == 442)
                BaseSoundID = -1;
        }
    }
}