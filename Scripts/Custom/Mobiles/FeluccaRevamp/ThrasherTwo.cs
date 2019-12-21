using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a thrasher corpse")]
    public class ThrasherTwo : BaseCreature
    {
        [Constructable]
        public ThrasherTwo()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.1, 0.2)
        {
            Name = "Thrasher";
            Body = 0xCE;
            Hue = 0x497;
            BaseSoundID = 0x294;

            SetStr(293, 427);
            SetDex(227, 250);
            SetInt(115, 167);

            SetHits(2600, 9840);

            SetDamage(25, 45);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 53, 55);
            SetResistance(ResistanceType.Fire, 25, 29);
            SetResistance(ResistanceType.Poison, 25, 28);

            SetSkill(SkillName.Wrestling, 101.2, 118.3);
            SetSkill(SkillName.Tactics, 99.1, 117.3);
            SetSkill(SkillName.MagicResist, 102.4, 118.6);

            Fame = 22400;
            Karma = -22400;
			
			PackItem( new WhiteFang(5) ); 
			

            for (int i = 0; i < Utility.RandomMinMax(0, 1); i++)
            {
                PackItem(Loot.RandomScroll(0, Loot.ArcanistScrollTypes.Length, SpellbookType.Arcanist));
            }

            SetWeaponAbility(WeaponAbility.ArmorIgnore);
        }

        public ThrasherTwo(Serial serial)
            : base(serial)
        {
        }

        public override bool GivesMLMinorArtifact
        {
            get
            {
                return true;
            }
        }
        public override int Hides
        {
            get
            {
                return 48;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.AosFilthyRich, 4);
 
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);		
							
            c.DropItem(new ThrashersTail());
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
			
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
			
            int version = reader.ReadInt();
        }
    }
}