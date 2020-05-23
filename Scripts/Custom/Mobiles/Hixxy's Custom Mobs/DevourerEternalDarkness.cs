using System;
using System.Collections;
using Server.Items;
using Server.Spells;

namespace Server.Mobiles
{
	// SlasherOfVeils
	
    [CorpseName("the remains of Eternal Darkness")]
    public class DevourerEternalDarkness : BaseCreature
    {
        private static readonly int[] m_North = new int[]
        {
            -1, -1,
            1, -1,
            -1, 2,
            1, 2
        };
        private static readonly int[] m_East = new int[]
        {
            -1, 0,
            2, 0
        };

        [Constructable]
        public DevourerEternalDarkness()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "Devourer of Eternal Darkness";
            Body = 1069;

            SetStr(901, 1010);
            SetDex(127, 153);
            SetInt(1078, 1263);

            SetHits(50000, 65000);
            SetMana(30000);

            SetDamage(100, 150);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Fire, 50);
            SetDamageType(ResistanceType.Cold, 50);
            SetDamageType(ResistanceType.Poison, 50);
            SetDamageType(ResistanceType.Energy, 50);

            SetResistance(ResistanceType.Physical, 65, 80);
            SetResistance(ResistanceType.Fire, 70, 80);
            SetResistance(ResistanceType.Cold, 70, 80);
            SetResistance(ResistanceType.Poison, 70, 80);
            SetResistance(ResistanceType.Energy, 70, 80);

            SetSkill(SkillName.Anatomy, 110.8, 129.7);
            SetSkill(SkillName.EvalInt, 113.4, 130);
            SetSkill(SkillName.Magery, 111.7, 130);
            SetSkill(SkillName.Spellweaving, 111.1, 125);
            SetSkill(SkillName.Meditation, 113.5, 129.9);
            SetSkill(SkillName.MagicResist, 110, 129.8);
            SetSkill(SkillName.Tactics, 110.5, 126.3);
            SetSkill(SkillName.Wrestling, 110.1, 130);
            SetSkill(SkillName.DetectHidden, 300.1);
			MagicDamageAbsorb = 65;
			MeleeDamageAbsorb = 65;

            Fame = 35000;
            Karma = -35000;
			
			PackItem( new WhiteFang(30) );	
			PackItem( new DonationToken(1) );	
			PackItem( new MagicClothDeed(1) );

            SetSpecialAbility(SpecialAbility.AngryFire);
            SetSpecialAbility(SpecialAbility.ManaDrain);
            SetWeaponAbility(WeaponAbility.ParalyzingBlow);
            SetSpecialAbility(SpecialAbility.TrueFear);
			SetWeaponAbility(WeaponAbility.BleedAttack);
        }

        public DevourerEternalDarkness(Serial serial)
            : base(serial)
        {
        }

        public override bool Unprovokable
        {
            get
            {
                return false;
            }
        }
        public override bool BardImmune
        {
            get
            {
                return false;
            }
        }
        public override int GetIdleSound()
        {
            return 1589;
        }

        public override int GetAngerSound()
        {
            return 1586;
        }

        public override int GetHurtSound()
        {
            return 1588;
        }

        public override int GetDeathSound()
        {
            return 1587;
        }

		public override bool AlwaysMurderer
        {
            get
            {
                return true;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.AosSuperBoss, 4);
            AddLoot(LootPack.Gems, 8);
        }


        public override void OnThink()
        {
            base.OnThink();

            //if (Combatant == null)
            //    return;

            //if (Hits > 0.6 * HitsMax && Utility.RandomDouble() < 0.05)
            //    FireRing();
        }


        public override void OnDamagedBySpell(Mobile caster)
        {
            if (0.5 > Utility.RandomDouble() && caster.InRange(Location, 10) && Map != null && caster.Alive && caster != this && caster.Map == Map)
            {
                MoveToWorld(caster.Location, Map);

                Timer.DelayCall(() =>
                {
                    Combatant = caster;
                });

                Effects.PlaySound(Location, Map, 0x1FE);
            }

            base.OnDamagedBySpell(caster);
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
