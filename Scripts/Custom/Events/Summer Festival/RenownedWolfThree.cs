using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a corrupted wolf corpse")]  
    public class RenownedWolfThree : BaseCreature
    {
        [Constructable]
        public RenownedWolfThree()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a corrupted wolf";
            BodyValue = 1070;
            BaseSoundID = 229;

            Hue = 0;

            SetStr(800, 1199);
            SetDex(200, 250);
            SetInt(202, 336);

            SetHits(5111, 5478);

            SetDamage(22, 29);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Fire, 25);
            SetDamageType(ResistanceType.Energy, 25);

            SetResistance(ResistanceType.Physical, 60, 93);
            SetResistance(ResistanceType.Fire, 60, 100);
            SetResistance(ResistanceType.Cold, 40, 70);
            SetResistance(ResistanceType.Poison, 100);
            SetResistance(ResistanceType.Energy, 37, 50);

            SetSkill(SkillName.MagicResist, 110.1, 132.6);
            SetSkill(SkillName.Tactics, 86.9, 95.5);
            SetSkill(SkillName.Wrestling, 42.2, 98.8);
            SetSkill(SkillName.Magery, 97.1, 100.8);
            SetSkill(SkillName.EvalInt, 91.1, 91.8);
            SetSkill(SkillName.Meditation, 45.4, 94.1);
            SetSkill(SkillName.Anatomy, 45.4, 74.1);

            Fame = 7000;
            Karma = -10000;
			
			PackItem( new SummerToken(5) );

            VirtualArmor = 55;

            SetWeaponAbility(WeaponAbility.ConcussionBlow);
        }

        public RenownedWolfThree(Serial serial)
            : base(serial)
        {
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich, 2);
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