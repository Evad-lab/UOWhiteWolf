using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("an Ice horse corpse")]
    public class Icehorse : BaseMount
    {
        [Constructable]
        public Icehorse()
            : this("an Ice horse")
        {
        }

        [Constructable]
        public Icehorse(string name)
            : base(name, 0x74, 0x3EA7, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            BaseSoundID = 0xA8;
            BodyValue = 116;
            Hue = 2729;

            SetStr(700, 755);
            SetDex(89, 125);
            SetInt(200, 260);

            SetHits(2555, 2650);

            SetDamage(25, 36);

            SetDamageType(ResistanceType.Physical, 40);
            SetDamageType(ResistanceType.Poison, 20);
            SetDamageType(ResistanceType.Energy, 40);

            SetResistance(ResistanceType.Physical, 65, 75);
            SetResistance(ResistanceType.Fire, 20, 40);
            SetResistance(ResistanceType.Cold, 20, 40);
            SetResistance(ResistanceType.Poison, 50, 60);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.EvalInt, 15.2, 19.3);
            SetSkill(SkillName.Magery, 39.5, 49.5);
            SetSkill(SkillName.MagicResist, 91.4, 93.4);
            SetSkill(SkillName.Tactics, 108.1, 110.0);
            SetSkill(SkillName.Wrestling, 97.3, 98.2);

            Fame = 15000;
            Karma = -15000;

            VirtualArmor = 60;

            Tamable = true;
            ControlSlots = 5;
            MinTameSkill = 108.0;
        }

        public Icehorse(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 5;
            }
        }
        public override int Hides
        {
            get
            {
                return 10;
            }
        }
        public override HideType HideType
        {
            get
            {
                return HideType.Barbed;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.Meat;
            }
        }
        public override bool CanAngerOnTame
        {
            get
            {
                return true;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
            AddLoot(LootPack.Average);
            AddLoot(LootPack.LowScrolls);
            AddLoot(LootPack.Potions);
        }

        public override int GetAngerSound()
        {
            if (!Controlled)
                return 0x16A;

            return base.GetAngerSound();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version == 0)
            {
                SetDamageType(ResistanceType.Physical, 40);
            }
        }
    }
}
