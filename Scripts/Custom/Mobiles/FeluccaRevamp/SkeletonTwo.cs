using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a skeletal corpse")]
    public class SkeletonTwo : BaseCreature
    {
        [Constructable]
        public SkeletonTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a skeleton";
            this.Body = Utility.RandomList(50, 56);
            this.BaseSoundID = 0x48D;

            this.SetStr(156, 180);
            this.SetDex(56, 75);
            this.SetInt(16, 40);

            this.SetHits(434, 448);

            this.SetDamage(13, 27);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 15, 20);
            this.SetResistance(ResistanceType.Fire, 5, 10);
            this.SetResistance(ResistanceType.Cold, 25, 40);
            this.SetResistance(ResistanceType.Poison, 25, 35);
            this.SetResistance(ResistanceType.Energy, 5, 15);

            this.SetSkill(SkillName.MagicResist, 45.1, 60.0);
            this.SetSkill(SkillName.Tactics, 45.1, 60.0);
            this.SetSkill(SkillName.Wrestling, 45.1, 55.0);

            this.Fame = 450;
            this.Karma = -450;
			
			PackItem( new WhiteFang(1) );

            this.VirtualArmor = 16;

            switch ( Utility.Random(5))
            {
                case 0:
                    this.PackItem(new BoneArms());
                    break;
                case 1:
                    this.PackItem(new BoneChest());
                    break;
                case 2:
                    this.PackItem(new BoneGloves());
                    break;
                case 3:
                    this.PackItem(new BoneLegs());
                    break;
                case 4:
                    this.PackItem(new BoneHelm());
                    break;
            }
        }

        public SkeletonTwo(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmune
        {
            get
            {
                return true;
            }
        }
        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Lesser;
            }
        }

        public override TribeType Tribe { get { return TribeType.Undead; } }

         public override OppositionGroup OppositionGroup
        {
            get
            {
                return OppositionGroup.FeyAndUndead;
            }
        }
        
        public override bool IsEnemy(Mobile m)
        {
            if(Region.IsPartOf("Haven Island"))
            {
                return false;
            }
            
            return base.IsEnemy(m);
        }
        
       public override void GenerateLoot()
        {
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
