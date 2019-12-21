using System;

namespace Server.Mobiles
{
    [CorpseName("a mongbat corpse")]
    public class MongbatTwo : BaseCreature
    {
        [Constructable]
        public MongbatTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a mongbat";
            Body = 39;
            BaseSoundID = 422;

            SetStr(16, 20);
            SetDex(26, 38);
            SetInt(6, 14);

            SetHits(400, 600);
            SetMana(0);

            SetDamage(10, 20);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 5, 10);

            SetSkill(SkillName.MagicResist, 5.1, 14.0);
            SetSkill(SkillName.Tactics, 5.1, 10.0);
            SetSkill(SkillName.Wrestling, 5.1, 10.0);

            Fame = 150;
            Karma = -150;

            VirtualArmor = 10;

            Tamable = false;
            ControlSlots = 1;
            MinTameSkill = -18.9;
        }

        public MongbatTwo(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.Meat;
            }
        }

        public override bool CanFly
        {
            get
            {
                return true;
            }
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Poor);
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