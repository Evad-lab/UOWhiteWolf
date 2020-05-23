using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Mobiles
{
	//Medusa
	
    [CorpseName("a corpse of the pink goddess")]
    public class PinkGoddess : BaseSABoss
    {
        private List<Mobile> m_TurnedToStone = new List<Mobile>();
        public List<Mobile> AffectedMobiles { get { return m_TurnedToStone; } }

        public List<Mobile> m_Helpers = new List<Mobile>();

        private int m_Scales;
        private DateTime m_GazeDelay;
        private DateTime m_StoneDelay;
        private DateTime m_NextCarve;

        [Constructable]
        public PinkGoddess()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.1, 0.2)
        {
            Name = "The Pink Goddess";
            BodyValue = 175;
			Hue = 14;

            SetStr(700, 1000);
            SetDex(128, 139);
            SetInt(537, 664);

            SetHits(125000);

            SetDamage(51, 88);

            SetDamageType(ResistanceType.Physical, 25);
            SetDamageType(ResistanceType.Fire, 25);
            SetDamageType(ResistanceType.Energy, 25);
			SetDamageType(ResistanceType.Cold, 25);
			SetDamageType(ResistanceType.Poison, 25);

            SetResistance(ResistanceType.Physical, 55, 65);
            SetResistance(ResistanceType.Fire, 55, 65);
            SetResistance(ResistanceType.Cold, 55, 65);
            SetResistance(ResistanceType.Poison, 80, 90);
            SetResistance(ResistanceType.Energy, 60, 75);

            SetSkill(SkillName.Anatomy, 110.6, 116.1);
            SetSkill(SkillName.EvalInt, 100.0, 114.4);
            SetSkill(SkillName.Magery, 100.0);
            SetSkill(SkillName.Meditation, 118.2, 127.8);
            SetSkill(SkillName.MagicResist, 120.0);
            SetSkill(SkillName.Tactics, 111.9, 134.5);
            SetSkill(SkillName.Wrestling, 119.7, 128.9);
			MagicDamageAbsorb = 65;
			MeleeDamageAbsorb = 65;

            Fame = 22000;
            Karma = -22000;

            VirtualArmor = 60;

            PackItem(new Arrow(Utility.RandomMinMax(100, 200)));

            IronwoodCompositeBow Bow = new IronwoodCompositeBow();
            Bow.Movable = false;
            AddItem(Bow);

            m_Scales = Utility.RandomMinMax(1, 2) + 7;

            SetWeaponAbility(WeaponAbility.MortalStrike);
            SetSpecialAbility(SpecialAbility.VenomousBite);
			
			PackItem( new WhiteFang(30) );	
			PackItem( new DonationToken(1) );	
			PackItem( new MagicClothDeed(1) );
			
			
        }

        public PinkGoddess(Serial serial)
            : base(serial)
        {
        }

        public override Type[] UniqueSAList
        {
            get { return new Type[] { typeof(Slither), typeof(IronwoodCompositeBow), typeof(Venom), typeof(PetrifiedSnake), typeof(StoneDragonsTooth), typeof(MedusaFloorTileAddonDeed) }; }
        }

        public override Type[] SharedSAList
        {
            get { return new Type[] { typeof(SummonersKilt) }; }
        }
		
		public override bool IgnoreYoungProtection { get { return true; } }
        public override bool AutoDispel { get { return true; } }
        public override double AutoDispelChance { get { return 1.0; } }
        public override bool BardImmune { get { return true; } }
        public override Poison PoisonImmune { get { return Poison.Lethal; } }
        public override Poison HitPoison { get { return (0.8 >= Utility.RandomDouble() ? Poison.Deadly : Poison.Lethal); } }

        public override int GetIdleSound() { return 1557; }
        public override int GetAngerSound() { return 1554; }
        public override int GetHurtSound() { return 1556; }
        public override int GetDeathSound() { return 1555; }
		

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
       
   