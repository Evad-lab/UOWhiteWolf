using System;

namespace Server.Mobiles
{
    [CorpseName("a cyclopean corpse")]
    public class CyclopsTwo : BaseCreature
    {
        [Constructable]
        public CyclopsTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a cyclopean warrior";
            this.Body = 75;
            this.BaseSoundID = 604;

            this.SetStr(636, 685);
            this.SetDex(96, 115);
            this.SetInt(31, 55);

            this.SetHits(3202, 3231);
            this.SetMana(0);

            this.SetDamage(27, 43);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 45, 50);
            this.SetResistance(ResistanceType.Fire, 30, 40);
            this.SetResistance(ResistanceType.Cold, 25, 35);
            this.SetResistance(ResistanceType.Poison, 30, 40);
            this.SetResistance(ResistanceType.Energy, 30, 40);

            this.SetSkill(SkillName.MagicResist, 60.3, 105.0);
            this.SetSkill(SkillName.Tactics, 80.1, 100.0);
            this.SetSkill(SkillName.Wrestling, 80.1, 90.0);

            this.Fame = 4500;
            this.Karma = -4500;
			

            this.VirtualArmor = 48;
        }

        public CyclopsTwo(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 4;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 3;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Rich);
            this.AddLoot(LootPack.Average);
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