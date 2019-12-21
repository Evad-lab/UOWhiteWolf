using System;
using Server.Factions;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a silver serpent corpse")]
    [TypeAlias("Server.Mobiles.Silverserpant")]
    public class SilverSerpentTwo : BaseCreature
    {
        [Constructable]
        public SilverSerpentTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Body = 92;
            Name = "a silver serpent";
            BaseSoundID = 219;
            Hue = 1150;

            SetStr(261, 560);
            SetDex(251, 600);
            SetInt(121, 140);

            SetHits(297, 516);

            SetDamage(25, 45);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Poison, 50);

            SetResistance(ResistanceType.Physical, 35, 45);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 5, 10);
            SetResistance(ResistanceType.Poison, 100);
            SetResistance(ResistanceType.Energy, 5, 10);

            SetSkill(SkillName.Poisoning, 90.1, 100.0);
            SetSkill(SkillName.MagicResist, 95.1, 100.0);
            SetSkill(SkillName.Tactics, 80.1, 95.0);
            SetSkill(SkillName.Wrestling, 85.1, 100.0);
            SetSkill(SkillName.DetectHidden, 50.0, 55.0);

            Fame = 7000;
            Karma = -7000;

            VirtualArmor = 40;
			
			PackItem( new WhiteFang(2) );
			
			
        }

        public SilverSerpentTwo(Serial serial)
            : base(serial)
        {
        }

        public override Faction FactionAllegiance { get { return TrueBritannians.Instance; } }
        public override Ethics.Ethic EthicAllegiance { get { return Ethics.Ethic.Hero; } }
        public override bool DeathAdderCharmable { get { return true; } }
        public override int Meat { get { return 1; } }
        public override Poison PoisonImmune { get { return Poison.Lethal; } }
        public override Poison HitPoison { get { return Poison.Lethal; } }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems, 2);

        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Utility.RandomDouble() < 0.1)
                c.DropItem(new SilverSerpentVenom());
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

            if (BaseSoundID == -1)
                BaseSoundID = 219;
        }
    }
}