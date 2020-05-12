using System;
using System.Collections;
using Server.Engines.CannedEvil;
using Server.Items;

namespace Server.Mobiles
{
    public class OakKing : BaseChampion
    {
        [Constructable]
        public OakKing()
            : base(AIType.AI_Mage)
        {
            Name = "The Oak King";
            BodyValue = 829;
            BaseSoundID = 0x4B0;

            SetStr(5020, 6000);
            SetDex(1020, 2000);
            SetInt(601, 750);

            SetHits(200000, 250000);
            SetStam(103, 250);

            SetDamage(29, 35);

            SetDamageType(ResistanceType.Physical, 75);
            SetDamageType(ResistanceType.Fire, 25);

            SetResistance(ResistanceType.Physical, 75, 90);
            SetResistance(ResistanceType.Fire, 65, 75);
            SetResistance(ResistanceType.Cold, 60, 70);
            SetResistance(ResistanceType.Poison, 65, 75);
            SetResistance(ResistanceType.Energy, 65, 75);

            SetSkill(SkillName.EvalInt, 95.1, 100.0);
            SetSkill(SkillName.Magery, 90.1, 105.0);
            SetSkill(SkillName.Meditation, 95.1, 100.0);
            SetSkill(SkillName.MagicResist, 120.2, 140.0);
            SetSkill(SkillName.Tactics, 90.1, 105.0);
            SetSkill(SkillName.Wrestling, 90.1, 105.0);

            Fame = 24000;
            Karma = -24000;

            VirtualArmor = 20;
            SetSpecialAbility(SpecialAbility.LifeDrain);
			
			PackItem( new SummerToken(50) );

            ForceActiveSpeed = 0.3;
            ForcePassiveSpeed = 0.6;
        }

        public OakKing(Serial serial)
            : base(serial)
        {
        }

        public override ChampionSkullType SkullType
        {
            get
            {
                return ChampionSkullType.Pain;
            }
        }
        public override Type[] UniqueList
        {
            get
            {
                return new Type[] { typeof(GladiatorsCollar) };
            }
        }
        public override Type[] SharedList
        {
            get
            {
                return new Type[] { typeof(RoyalGuardSurvivalKnife), typeof(TheMostKnowledgePerson), typeof(LieutenantOfTheBritannianRoyalGuard) };
            }
        }
        public override Type[] DecorativeList
        {
            get
            {
                return new Type[] { typeof(LavaTile), typeof(DemonSkull) };
            }
        }
        public override MonsterStatuetteType[] StatueTypes
        {
            get
            {
                return new MonsterStatuetteType[] { };
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
            AddLoot(LootPack.UltraRich, 4);
            AddLoot(LootPack.FilthyRich);
        }

        public override void CheckReflect(Mobile caster, ref bool reflect)
        {
            if (!caster.Female && !caster.IsBodyMod)
                reflect = true; // Always reflect if caster isn't female
        }

        /*public override void AlterDamageScalarFrom(Mobile caster, ref double scalar)
        {
            if (caster.Body.IsMale)
                scalar = 20; // Male bodies always reflect.. damage scaled 20x
        }*/

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
