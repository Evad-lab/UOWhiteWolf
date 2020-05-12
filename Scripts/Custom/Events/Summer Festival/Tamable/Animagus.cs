using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a corpse of an Animagus")]
    public class Animagus : BaseMount
    {
        public override double HealChance { get { return 1.0; } }

        [Constructable]
        public Animagus()
            : this("Animagus")
        {
        }

        [Constructable]
        public Animagus(string name)
            : base(name, 277, 0x3E91, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            double chance = Utility.RandomDouble() * 23301;


            Hue = 2725;
			BodyValue = 719;
			BaseSoundID = 229;
			ItemID = 16076;
			


            SetStr(800, 1000);
            SetDex(800, 1000);
            SetInt(600, 800);

            SetHits(4500, 5000);

            SetDamage(30, 40);

            SetDamageType(ResistanceType.Physical, 100);
            SetDamageType(ResistanceType.Cold, 98);
            SetDamageType(ResistanceType.Energy, 98);
			SetDamageType( ResistanceType.Fire, 98 );
			SetDamageType( ResistanceType.Poison, 98 );

            SetResistance(ResistanceType.Physical, 100);
            SetResistance(ResistanceType.Fire, 80);
            SetResistance(ResistanceType.Cold, 80);
            SetResistance(ResistanceType.Poison, 80);
            SetResistance(ResistanceType.Energy, 80);

            SetSkill(SkillName.Wrestling, 110.1, 155.8);
			SetSkill(SkillName.Anatomy, 100.1, 128.8);
			SetSkill(SkillName.Tactics, 137.6, 158.0 );
			SetSkill(SkillName.Healing, 100.0, 130.0);

            Fame = 5000;  //Guessing here
            Karma = 5000;  //Guessing here

            Tamable = true;
            ControlSlots = 7;
            MinTameSkill = 110;

            if (Utility.RandomDouble() < 0.2)
                PackItem(new TreasureMap(5, Map.Trammel));

            //if ( Utility.RandomDouble() < 0.1 )
            //PackItem( new ParrotItem() );

            PackGold(500, 800);
            // TODO 0-2 spellweaving scroll

            SetWeaponAbility(WeaponAbility.BleedAttack);
			SetSpecialAbility(SpecialAbility.Heal);
        }

        public Animagus(Serial serial)
            : base(serial)
        {
        }

		//UOWW = commented out on core upgrade for compatilibty with BaseCreature.cs
		//
        /*public override bool CanHealOwner
        {
            get
            {
                return true;
            }
        }*/
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.FruitsAndVegies;
            }
        }
        public override bool StatLossAfterTame
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
                return 10;
            }
        }
        public override int Meat
        {
            get
            {
                return 3;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.AosFilthyRich, 5);
        }

        public override void OnAfterTame(Mobile tamer)
        {
            if (PetTrainingHelper.Enabled)
            {
                RawStr = (int)Math.Max(1, RawStr * 0.5);
                RawDex = (int)Math.Max(1, RawDex * 0.5);

                HitsMaxSeed = RawStr;
                Hits = RawStr;

                StamMaxSeed = RawDex;
                Stam = RawDex;
            }
            else
            {
                base.OnAfterTame(tamer);
            }
        }

        public override int GetIdleSound()
        {
            return 0x577;
        }

        public override int GetAttackSound()
        {
            return 0x576;
        }

        public override int GetAngerSound()
        {
            return 0x578;
        }

        public override int GetHurtSound()
        {
            return 0x576;
        }

        public override int GetDeathSound()
        {
            return 0x579;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)3); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version < 3 && Controlled && RawStr >= 1200 && ControlSlots == ControlSlotsMin)
            {
                Server.SkillHandlers.AnimalTaming.ScaleStats(this, 0.5);
            }

            if (version < 1 && Name == "Animagus")
                Name = "Animagus";

            if (version == 1)
            {
                SetWeaponAbility(WeaponAbility.BleedAttack);
            }
        }
    }
}