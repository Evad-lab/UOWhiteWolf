using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a mummy corpse")]
    public class MummyTwo : BaseCreature
    {
        [Constructable]
        public MummyTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.4, 0.8)
        {
            this.Name = "a mummy";
            this.Body = 154;
            this.BaseSoundID = 471;

            this.SetStr(546, 570);
            this.SetDex(71, 90);
            this.SetInt(26, 40);

            this.SetHits(2008, 2022);

            this.SetDamage(33, 33);

            this.SetDamageType(ResistanceType.Physical, 40);
            this.SetDamageType(ResistanceType.Cold, 60);

            this.SetResistance(ResistanceType.Physical, 45, 55);
            this.SetResistance(ResistanceType.Fire, 10, 20);
            this.SetResistance(ResistanceType.Cold, 50, 60);
            this.SetResistance(ResistanceType.Poison, 20, 30);
            this.SetResistance(ResistanceType.Energy, 20, 30);

            this.SetSkill(SkillName.MagicResist, 15.1, 40.0);
            this.SetSkill(SkillName.Tactics, 35.1, 50.0);
            this.SetSkill(SkillName.Wrestling, 35.1, 50.0);

            this.Fame = 4000;
            this.Karma = -4000;
			
			PackItem( new WhiteFang(3) );

            this.VirtualArmor = 50;

            if (Core.ML && Utility.RandomDouble() < .33)
                this.PackItem(Engines.Plants.Seed.RandomPeculiarSeed(3));

            this.PackItem(new Garlic(5));
            this.PackItem(new Bandage(10));
        }

        public MummyTwo(Serial serial)
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
        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Lesser;
            }
        }

        public override TribeType Tribe { get { return TribeType.Undead; } }

        public override OppositionGroup OppositionGroup
        {
            get
            {
                return OppositionGroup.FeyAndUndead;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Rich);
            this.AddLoot(LootPack.Gems);
            this.AddLoot(LootPack.Potions);
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
