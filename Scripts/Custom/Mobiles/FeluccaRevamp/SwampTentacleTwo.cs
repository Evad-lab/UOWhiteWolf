using System;

namespace Server.Mobiles
{
    [CorpseName("a swamp tentacle corpse")]
    public class SwampTentacleTwo : BaseCreature
    {
        [Constructable]
        public SwampTentacleTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a swamp tentacle";
            this.Body = 66;
            this.BaseSoundID = 352;

            this.SetStr(196, 320);
            this.SetDex(166, 185);
            this.SetInt(116, 130);

            this.SetHits(158, 172);
            this.SetMana(0);

            this.SetDamage(16, 22);

            this.SetDamageType(ResistanceType.Physical, 40);
            this.SetDamageType(ResistanceType.Poison, 60);

            this.SetResistance(ResistanceType.Physical, 25, 35);
            this.SetResistance(ResistanceType.Fire, 10, 20);
            this.SetResistance(ResistanceType.Cold, 10, 20);
            this.SetResistance(ResistanceType.Poison, 60, 80);
            this.SetResistance(ResistanceType.Energy, 10, 20);

            this.SetSkill(SkillName.MagicResist, 15.1, 20.0);
            this.SetSkill(SkillName.Tactics, 65.1, 80.0);
            this.SetSkill(SkillName.Wrestling, 65.1, 80.0);

            this.Fame = 3000;
            this.Karma = -3000;

            this.VirtualArmor = 28;

            this.PackReg(3);
			

			
        }

        public SwampTentacleTwo(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Greater;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Rich);
			
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