using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a small puddle of melted chocolate")]
    public class SmDKChocolate : BaseCreature
    {
        [Constructable]
        public SmDKChocolate ()
            : base(AIType.AI_Spellweaving, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a small piece of dark chocolate";
            Body = 779;
            BaseSoundID = 422;
			Hue = 2018;

            SetStr(96, 120);
            SetDex(91, 115);
            SetInt(21, 45);

            SetHits(3000, 4000);

            SetDamage(15, 25);

            SetDamageType(ResistanceType.Physical, 50);
			SetDamageType(ResistanceType.Fire, 50);
			SetDamageType(ResistanceType.Energy, 50);

            SetResistance(ResistanceType.Physical, 25, 45);
            SetResistance(ResistanceType.Fire, 25, 45);
            SetResistance(ResistanceType.Cold, 25, 45);
            SetResistance(ResistanceType.Poison, 99, 100);
            SetResistance(ResistanceType.Energy, 15, 25);

            SetSkill(SkillName.MagicResist, 75.1, 100.0);
            SetSkill(SkillName.Tactics, 55.1, 80.0);
            SetSkill(SkillName.Wrestling, 55.1, 75.0);
			SetSkill(SkillName.Spellweaving, 220.0, 300.00);
			SetSkill(SkillName.DetectHidden, 200.0, 300.00);

            Fame = 450;
            Karma = -450;
			
			PackItem( new WhiteFang(10) );

            VirtualArmor = 28;

            PackItem(new Log(4));
            PackItem(new Engines.Plants.Seed());
        }

        public SmDKChocolate(Serial serial)
            : base(serial)
        {
        }

        public override int Hides
        {
            get
            {
                return 6;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
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