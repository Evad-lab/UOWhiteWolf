using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a fairy corpse")]
    public class FairyFriendDonation : BaseCreature
    {
		
		public override double HealChance { get { return 1.0; } }
		
        [Constructable]
        public FairyFriendDonation()
            : base(AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "Friendly Fairy";
            this.Body = 128;
            this.BaseSoundID = 0x467;

            this.SetStr(550);
            this.SetDex(400);
            this.SetInt(1000);

            this.SetHits(800);
            this.SetStam(300);
            this.SetMana(700);

            this.SetDamage(20, 25);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 70, 90);
            this.SetResistance(ResistanceType.Fire, 60, 70);
            this.SetResistance(ResistanceType.Cold, 70, 80);
            this.SetResistance(ResistanceType.Poison, 60, 70);
            this.SetResistance(ResistanceType.Energy, 60, 70);

            this.SetSkill(SkillName.EvalInt, 190.0, 200.0);
            this.SetSkill(SkillName.Magery, 150.1, 180.0);
            this.SetSkill(SkillName.Meditation, 100.0, 100.0);
            this.SetSkill(SkillName.MagicResist, 110.5, 150.0);
			this.SetSkill(SkillName.Healing, 110.5, 150.0);
            this.SetSkill(SkillName.Tactics, 100.1, 120.0);
            this.SetSkill(SkillName.Wrestling, 100.1, 120.0);

            this.Fame = 7000;
            this.Karma = 7000;
			
            Tamable = true;
            ControlSlots = 3;
			ControlSlotsMin = 3;
			ControlSlotsMax = 3;
            MinTameSkill = 120.0;

            this.VirtualArmor = 100;

            if (0.02 > Utility.RandomDouble())
                this.PackStatue();				
        }
        public FairyFriendDonation(Serial serial)
            : base(serial)
        {
        }
		
        public override bool InitialInnocent
        {
            get
            {
                return true;
            }
        }
        public override HideType HideType
        {
            get
            {
                return HideType.Spined;
            }
        }
        public override int Hides
        {
            get
            {
                return 5;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override OppositionGroup OppositionGroup
        {
            get
            {
                return OppositionGroup.FeyAndUndead;
            }
        }
        public override void GenerateLoot()
        {
			AddLoot(LootPack.UltraRich, 2);
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