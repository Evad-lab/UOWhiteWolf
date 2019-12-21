using System;
using Server.Factions;
using Server.Items;
using Server.Misc;

namespace Server.Mobiles
{
    [CorpseName("a corpse of dead feelings")]
    public class ColdFeelings : BaseCreature
    {
        [Constructable]
        public ColdFeelings()
            : base(AIType.AI_Spellweaving, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "cold feelings";
            this.Body = 58;
            this.BaseSoundID = 466;
			this.Hue = 1109;

            this.SetStr(196, 225);
            this.SetDex(196, 225);
            this.SetInt(196, 225);

            this.SetHits(3000, 4000);

            this.SetDamage(17, 18);

            this.SetDamageType(ResistanceType.Physical, 50);
            this.SetDamageType(ResistanceType.Energy, 50);

            this.SetResistance(ResistanceType.Physical, 35, 45);
            this.SetResistance(ResistanceType.Fire, 20, 40);
            this.SetResistance(ResistanceType.Cold, 10, 30);
            this.SetResistance(ResistanceType.Poison, 5, 10);
            this.SetResistance(ResistanceType.Energy, 50, 70);

            this.SetSkill(SkillName.EvalInt, 80.0);
            this.SetSkill(SkillName.Magery, 80.0);
            this.SetSkill(SkillName.MagicResist, 80.0);
            this.SetSkill(SkillName.Tactics, 80.0);
            this.SetSkill(SkillName.Wrestling, 80.0);
			this.SetSkill(SkillName.Spellweaving, 220.0, 300.00);
			this.SetSkill(SkillName.DetectHidden, 200.0, 300.00);

            this.Fame = 4000;
            this.Karma = 0;
			
			PackItem( new WhiteFang(10) );

            this.VirtualArmor = 40;

            if (Core.ML && Utility.RandomDouble() < .33)
                this.PackItem(Engines.Plants.Seed.RandomPeculiarSeed(4));

            this.AddItem(new LightSource());
        }

        public ColdFeelings(Serial serial)
            : base(serial)
        {
        }
        public override Faction FactionAllegiance
        {
            get
            {
                return CouncilOfMages.Instance;
            }
        }
        public override Ethics.Ethic EthicAllegiance
        {
            get
            {
                return Ethics.Ethic.Hero;
            }
        }
        public override TimeSpan ReacquireDelay
        {
            get
            {
                return TimeSpan.FromSeconds(1.0);
            }
        }

        public override TribeType Tribe { get { return TribeType.Fey; } }

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
