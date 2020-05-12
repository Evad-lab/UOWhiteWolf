using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a watery corpse")]
    public class CorruptedWaterSpiritFour : BaseRenowned
    {
        [Constructable]
        public CorruptedWaterSpiritFour()
            : base(AIType.AI_Mage)
        {
            this.Name = "a corrupted spray of water";
            this.BodyValue = 265;
            this.BaseSoundID = 278;
			this.Hue = 1927;

            this.SetStr(450, 600);
            this.SetDex(120, 185);
            this.SetInt(361, 435);

            this.SetHits(5200, 5400);

            this.SetDamage(9, 15);

            this.SetDamageType(ResistanceType.Physical, 25);
            this.SetDamageType(ResistanceType.Poison, 50);
            this.SetDamageType(ResistanceType.Energy, 25);

            this.SetResistance(ResistanceType.Physical, 40, 70);
            this.SetResistance(ResistanceType.Fire, 30, 50);
            this.SetResistance(ResistanceType.Cold, 20, 40);
            this.SetResistance(ResistanceType.Poison, 10, 30);
            this.SetResistance(ResistanceType.Energy, 20, 50);

            this.SetSkill(SkillName.EvalInt, 80.1, 100.0);
            this.SetSkill(SkillName.Magery, 80.1, 100.0);
            this.SetSkill(SkillName.MagicResist, 65.2, 100.0);
            this.SetSkill(SkillName.Tactics, 90.1, 100.0);
            this.SetSkill(SkillName.Wrestling, 80.1, 100.0);

            this.Fame = 12500;
            this.Karma = -12500;
			
			PackItem( new SummerToken(3) );

            this.VirtualArmor = 70;

            this.PackItem(new Nightshade(4));
            this.PackItem(new LesserPoisonPotion());
        }

        public CorruptedWaterSpiritFour(Serial serial)
            : base(serial)
        {
        }

        public override Type[] UniqueSAList
        {
            get
            {
                return new Type[] { typeof(BreastplateOfTheBerserker),  typeof(TerathanWarriorCostume)};
            }
        }
        public override Type[] SharedSAList
        {
            get
            {
                return new Type[] { typeof(MysticsGarb) };
            }
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
                return Poison.Lethal;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Rich, 2);
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
