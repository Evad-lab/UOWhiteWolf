using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a charred corpse")]
    public class FireGargoyleTwo : BaseCreature
    {
        [Constructable]
        public FireGargoyleTwo()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = NameList.RandomName("fire gargoyle");
            Body = 130;
            BaseSoundID = 0x174;

            SetStr(651, 800);
            SetDex(126, 145);
            SetInt(226, 250);

            SetHits(1211, 1240);

            SetDamage(17, 24);

            SetDamageType(ResistanceType.Physical, 20);
            SetDamageType(ResistanceType.Fire, 80);

            SetResistance(ResistanceType.Physical, 30, 35);
            SetResistance(ResistanceType.Fire, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 20, 30);

            SetSkill(SkillName.Anatomy, 75.1, 85.0);
            SetSkill(SkillName.EvalInt, 90.1, 105.0);
            SetSkill(SkillName.Magery, 90.1, 105.0);
            SetSkill(SkillName.Meditation, 90.1, 105.0);
            SetSkill(SkillName.MagicResist, 90.1, 105.0);
            SetSkill(SkillName.Tactics, 80.1, 100.0);
            SetSkill(SkillName.Wrestling, 40.1, 80.0);

            Fame = 3500;
            Karma = -3500;
			
			PackItem( new WhiteFang(2) );

            VirtualArmor = 32;
			
			//UOWW: activates Breath and Aura
            SetSpecialAbility(SpecialAbility.DragonBreath);
            SetAreaEffect(AreaEffect.AuraDamage);			
        }

        public FireGargoyleTwo(Serial serial)
            : base(serial)
        {
        }

        public override int TreasureMapLevel
        {
            get
            {
                return 1;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override bool CanFly
        {
            get
            {
                return true;
            }
        }

		//UOWW: commented out. Moved in special abilities in the new core
        //public override bool HasAura { get { return true; } }
        //public override int AuraRange { get { return 2; } }

		public void AuraEffect(Mobile m)
        //public override void AuraEffect(Mobile m)
        {
			m.SendLocalizedMessage(1008112); // The intense heat is damaging you!
            //m.SendMessage("The radiating heat scorches your skin!");
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
            AddLoot(LootPack.Gems);
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