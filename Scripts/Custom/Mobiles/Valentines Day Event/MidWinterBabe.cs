using System;
using System.Collections;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a corpse of a bitch")]
    public class MidWinterBabe : BaseCreature
    {
        [Constructable]
        public MidWinterBabe()
            : base(AIType.AI_NecroMage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "mid-winter babe";
			Title = "Ghost of Ex's";
            Body = 252;
            BaseSoundID = 0x482;

            SetStr(276, 305);
            SetDex(106, 125);
            SetInt(471, 495);

            SetHits(5000, 7000);

            SetDamage(25, 35);

            SetDamageType(ResistanceType.Physical, 20);
            SetDamageType(ResistanceType.Cold, 80);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Fire, 40, 55);
            SetResistance(ResistanceType.Cold, 70, 90);
            SetResistance(ResistanceType.Poison, 99, 100);
            SetResistance(ResistanceType.Energy, 65, 85);

            SetSkill(SkillName.Magery, 95.1, 110.0);
            SetSkill(SkillName.MagicResist, 90.1, 105.0);
            SetSkill(SkillName.Tactics, 80.1, 100.0);
            SetSkill(SkillName.Wrestling, 80.1, 100.0);
            SetSkill(SkillName.Necromancy, 90, 110.0);
            SetSkill(SkillName.SpiritSpeak, 90.0, 110.0);
			SetSkill(SkillName.DetectHidden, 200.0, 300.00);

            Fame = 15200;
            Karma = -15200;
			
			PackItem( new WhiteFang(10) );

            PackReg(3);
            PackItem(new Necklace());

            if (0.25 > Utility.RandomDouble())
                PackItem(Engines.Plants.Seed.RandomBonsaiSeed());

            SetWeaponAbility(WeaponAbility.ColdWind);
        }

        public MidWinterBabe(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmune
        {
            get
            {
                return true;
            }
        }
        public override bool CanRummageCorpses
        {
            get
            {
                return true;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 4;
            }
        }
        public override int GetDeathSound()
        {
            return 0x370;
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
            AddLoot(LootPack.Rich);
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