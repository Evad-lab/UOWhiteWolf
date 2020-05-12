using System;

namespace Server.Mobiles
{
    [CorpseName("a phoenix corpse")]
    public class PhoenixDonation : BaseCreature, IAuraCreature
    {
		
		public override double HealChance { get { return 1.0; } }
		
        [Constructable]
        public PhoenixDonation()
            : base(AIType.AI_Necro, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Name = "a phoenix";
            Body = 0x340;
            BaseSoundID = 0x8F;

            SetStr(1000, 1100);
            SetDex(402, 410);
            SetInt(804, 810);

            SetHits(1000, 1383);

            SetDamage(20, 35);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Fire, 50);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Fire, 60, 70);
            SetResistance(ResistanceType.Poison, 25, 35);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.SpiritSpeak, 90.2, 100.0);
            SetSkill(SkillName.Necromancy, 90.2, 100.0);
            SetSkill(SkillName.Poisoning, 90.1, 100.0);
            SetSkill(SkillName.MagicResist, 125.0, 135.0);
            SetSkill(SkillName.Tactics, 110.0, 115.0);
			SetSkill(SkillName.Anatomy, 110.0, 115.0);
            SetSkill(SkillName.Wrestling, 115.6, 120.8);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);
			SetSkill(SkillName.Healing, 50.0, 80.0);

            Fame = 15000;
            Karma = 0;
			Female = true;

            VirtualArmor = 60;

            Tamable = true;
            ControlSlots = 4;
            MinTameSkill = 120.0;

            SetAreaEffect(AreaEffect.AuraDamage);
        }

        public PhoenixDonation(Serial serial)
            : base(serial)
        {
        }

        public override bool CanAngerOnTame { get { return true; } }
        public override int Meat { get { return 1; } }
        public override MeatType MeatType { get { return MeatType.Bird; } }
        public override int Feathers { get { return 36; } }
        public override bool CanFly { get { return true; } }

        public void AuraEffect(Mobile m)
        {
            m.SendLocalizedMessage(1008112); // The intense heat is damaging you!
        }

        public override void OnAfterTame(Mobile tamer)
        {
            base.OnAfterTame(tamer);

            var profile = PetTrainingHelper.GetAbilityProfile(this);

            if (profile != null)
            {
                profile.RemoveAbility(AreaEffect.AuraDamage);
            }
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
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
