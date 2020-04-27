using System;
using System.Collections;

namespace Server.Mobiles
{
    [CorpseName("a broken chain corpse")]
    public class BallandChain : BaseCreature
    {
        [Constructable]
        public BallandChain()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a Ball and Chain";
            Body = 149;
            BaseSoundID = 0x4B0;

            SetStr(488, 620);
            SetDex(121, 170);
            SetInt(498, 657);

            SetHits(1012, 1053);

            SetDamage(15, 25);

            SetDamageType(ResistanceType.Physical, 75);
            SetDamageType(ResistanceType.Energy, 25);

            SetResistance(ResistanceType.Physical, 35, 50);
            SetResistance(ResistanceType.Fire, 30, 50);
            SetResistance(ResistanceType.Cold, 30, 50);
            SetResistance(ResistanceType.Poison, 30, 50);
            SetResistance(ResistanceType.Energy, 30, 50);

            SetSkill(SkillName.EvalInt, 190.1, 200.0);
            SetSkill(SkillName.Magery, 199.1, 200.0);
            SetSkill(SkillName.Meditation, 90.1, 100.0);
            SetSkill(SkillName.MagicResist, 100.5, 150.0);
            SetSkill(SkillName.Tactics, 80.1, 90.0);
            SetSkill(SkillName.Wrestling, 80.1, 90.0);
			SetSkill(SkillName.DetectHidden, 100.1, 120.0);

            Fame = 24000;
            Karma = -24000;
			

            VirtualArmor = 80;
			
			SetSpecialAbility(SpecialAbility.LifeDrain);
        }

        public BallandChain(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 5;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich, 4);
            AddLoot(LootPack.MedScrolls, 2);
        }
		
		//UOWW: DrainsLife compatibility with the new Core
		//
		public override void OnDrainLife(Mobile victim)
        {
            if (Map == null)
                return;

            ArrayList list = new ArrayList();
            int count = 0;
            IPooledEnumerable eable = GetMobilesInRange(20);

            foreach (Mobile m in eable)
            {
                if (m == this || !CanBeHarmful(m))
                {
                    if (m is DarkWisp) { count++; }
                    continue;
                }

                if (m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != Team))
                    list.Add(m);
                else if (m.Player)
                    list.Add(m);
            }

            eable.Free();

            foreach (Mobile m in list)
            {
                (new DarkWisp()).MoveToWorld(new Point3D(Location), Map);
                int teleportchance = Hits / HitsMax;

                if (teleportchance < Utility.RandomDouble() && m.Alive)
                {
                    switch (Utility.Random(6))
                    {
                        case 0: m.MoveToWorld(new Point3D(6431, 1664, 0), Map); break;
                        case 1: m.MoveToWorld(new Point3D(6432, 1634, 0), Map); break;
                        case 2: m.MoveToWorld(new Point3D(6401, 1657, 0), Map); break;
                        case 3: m.MoveToWorld(new Point3D(6401, 1637, 0), Map); break;
                        default: m.MoveToWorld(new Point3D(Location), Map); break;
                    }
                }
            }
        }

        //UOWW: commented out for compatilibty with the new Core
		//
		//public override bool DrainsLife { get { return true; } }

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