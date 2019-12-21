using Server;
using System;
 
namespace Server.Mobiles
{
	public class DazzledHarpyTwo : Harpy
	{
		[Constructable]
		public DazzledHarpyTwo()
		{
			Name = "a dazzled harpy";
            FightMode = FightMode.Aggressor;

            SetHits(520, 540);
            SetStam(90, 110);
            SetMana(50, 80);

            SetDamage(25, 27);

            SetSkill(SkillName.MagicResist, 50, 65);
            SetSkill(SkillName.Tactics, 70, 100);
            SetSkill(SkillName.Wrestling, 60, 90);
			
		}

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
		
		public DazzledHarpyTwo(Serial serial) : base(serial)
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write(0);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
	
	public class VampireMongbatTwo : Mongbat
	{
		[Constructable]
		public VampireMongbatTwo()
		{
			Name = "a vampire mongbat";
            FightMode = FightMode.Aggressor;
            Hue = 1461;

            SetHits(76, 171);

            SetStr(160, 200);
            SetDex(60, 80);
            SetInt(10, 30);

            SetHits(470, 870);
            SetStam(60, 80);
            SetMana(10, 30);

            SetDamage(25, 30);

            SetSkill(SkillName.Wrestling, 10, 20);
            SetSkill(SkillName.Tactics, 10, 20);
            SetSkill(SkillName.MagicResist, 25, 40);
			
		}

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }

		public VampireMongbatTwo(Serial serial) : base(serial)
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write(0);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
	
	public class HeadlessMinerTwo : HeadlessOne
	{
		[Constructable]
		public HeadlessMinerTwo()
		{
			Name = "headless miner";
            FightMode = FightMode.Aggressor;

            SetStr(160, 200);
            SetDex(40, 60);
            SetInt(10, 30);

            SetHits(500, 540);
            SetStam(40, 60);
            SetMana(10, 35);

            SetDamage(17, 22);

            SetSkill(SkillName.MagicResist, 30, 40);
            SetSkill(SkillName.Tactics, 40, 60);
            SetSkill(SkillName.Wrestling, 40, 60);
			
			
		}

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }

		public HeadlessMinerTwo(Serial serial) : base(serial)
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write(0);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
	
	public class StrangeGazerTwo : Gazer
	{
		[Constructable]
		public StrangeGazerTwo()
		{
			Name = "a strange gazer";

            SetStr(200, 330);
            SetDex(90, 120);
            SetInt(150, 160);

            SetHits(600, 690);
            SetStam(90, 120);
            SetMana(153, 158);

            SetDamage(25, 30);
			
            SetSkill(SkillName.MagicResist, 60, 80);
            SetSkill(SkillName.Tactics, 50, 70);
            SetSkill(SkillName.Wrestling, 50, 70);
            SetSkill(SkillName.Magery, 50, 70);
            SetSkill(SkillName.EvalInt, 50, 70);
            SetSkill(SkillName.Meditation, 50, 100);
			
			
			
		}

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average, 2);
        }

		public StrangeGazerTwo(Serial serial) : base(serial)
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write(0);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
}