using System;
using System.Collections;
using Server.Items;
using Server.Spells;

namespace Server.Mobiles
{
    [CorpseName("a shadow beast corpse")]
    public class ShadowBeast : BaseSABoss
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
        public ShadowBeast()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "Shadow Beast";
            BodyValue = 259;
			Hue = 1960;

            SetStr(2250);
            SetDex(127, 153);
            SetInt(2250);

            SetHits(500000, 650000);
            SetMana(10000);

            SetDamage(10, 15);
			
			
            SetDamageType(ResistanceType.Physical, 20);
            SetDamageType(ResistanceType.Fire, 20);
            SetDamageType(ResistanceType.Cold, 20);
            SetDamageType(ResistanceType.Poison, 20);
            SetDamageType(ResistanceType.Energy, 20);

            SetResistance(ResistanceType.Physical, 100);
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
            SetSkill(SkillName.DetectHidden, 127.1);

            Fame = 35000;
            Karma = -35000;
			
			PackItem( new SummerToken(40) );

            SetSpecialAbility(SpecialAbility.AngryFire);
            SetSpecialAbility(SpecialAbility.ManaDrain);
            SetWeaponAbility(WeaponAbility.ParalyzingBlow);
            SetSpecialAbility(SpecialAbility.TrueFear);
        }

        public ShadowBeast(Serial serial)
            : base(serial)
        {
        }

        public override Type[] UniqueSAList
        {
            get
            {
                return new Type[] { typeof(ClawsOfTheBerserker), typeof(Lavaliere), typeof(Mangler), typeof(HumanSignOfChaos), typeof(GargishSignOfChaos), typeof(StandardOfChaosG), typeof(StandardOfChaos) };
            }
        }
        public override Type[] SharedSAList
        {
            get
            {
                return new Type[] { typeof(AxesOfFury), typeof(BladeOfBattle), typeof(DemonBridleRing), typeof(PetrifiedSnake), typeof(PillarOfStrength), typeof(SwordOfShatteredHopes), typeof(SummonersKilt) };
            }
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

		public override bool AlwaysMurderer { get { return true; } }

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

        public override void FireRing()
        {
            for (int i = 0; i < m_North.Length; i += 2)
            {
                Point3D p = Location;

                p.X += m_North[i];
                p.Y += m_North[i + 1];

                IPoint3D po = p as IPoint3D;

                SpellHelper.GetSurfaceTop(ref po);

                Effects.SendLocationEffect(po, Map, 0x3E27, 50);
            }

            for (int i = 0; i < m_East.Length; i += 2)
            {
                Point3D p = Location;

                p.X += m_East[i];
                p.Y += m_East[i + 1];

                IPoint3D po = p as IPoint3D;

                SpellHelper.GetSurfaceTop(ref po);

                Effects.SendLocationEffect(po, Map, 0x3E31, 50);
            }
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
