using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a granite elemental corpse")]
    public class GraniteElemental : BaseCreature
    {
        [Constructable]
        public GraniteElemental()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a granite elemental";
            this.Body = 14;
            this.BaseSoundID = 268;

            this.SetStr(526, 555);
            this.SetDex(66, 85);
            this.SetInt(71, 92);

            this.SetHits(50176, 52193);

            this.SetDamage(25, 36);

            this.SetDamageType(ResistanceType.Physical, 50);
			this.SetDamageType(ResistanceType.Cold, 50);
			this.SetDamageType(ResistanceType.Poison, 50);

            this.SetResistance(ResistanceType.Physical, 75);
            this.SetResistance(ResistanceType.Fire, 75);
            this.SetResistance(ResistanceType.Cold, 75);
            this.SetResistance(ResistanceType.Poison, 75);
            this.SetResistance(ResistanceType.Energy, 75);

            this.SetSkill(SkillName.MagicResist, 50.1, 95.0);
            this.SetSkill(SkillName.Tactics, 60.1, 100.0);
            this.SetSkill(SkillName.Wrestling, 60.1, 100.0);
			this.SetSkill(SkillName.Magery, 60.1, 100.0);
			this.SetSkill(SkillName.EvalInt, 60.1, 100.0);

            this.Fame = 3500;
            this.Karma = -3500;
			
			PackItem( new WhiteFang(10) );

            this.VirtualArmor = 34;
            this.ControlSlots = 2;

            this.PackItem(new FertileDirt(Utility.RandomMinMax(1, 4)));
            this.PackItem(new MandrakeRoot());
			
            
        }

        public GraniteElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
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
                return Poison.Lethal;
            }
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
            this.AddLoot(LootPack.FilthyRich);
            this.AddLoot(LootPack.Meager);
            this.AddLoot(LootPack.Gems);
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