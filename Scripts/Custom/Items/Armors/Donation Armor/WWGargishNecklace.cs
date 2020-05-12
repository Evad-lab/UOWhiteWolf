using System;

namespace Server.Items
{
    public class WWGargishNecklace : BaseArmor
    {
        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

        public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Chainmail; } }
        public override ArmorMeditationAllowance DefMedAllowance { get { return ArmorMeditationAllowance.All; } }

        public override int BasePhysicalResistance { get { return 1; } }
        public override int BaseFireResistance { get { return 2; } }
        public override int BaseColdResistance { get { return 2; } }
        public override int BasePoisonResistance { get { return 2; } }
        public override int BaseEnergyResistance { get { return 3; } }
		
		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }

        [Constructable]
        public WWGargishNecklace()
            : base(0x4210)
        {
            Layer = Layer.Neck;
			
			Weight = 1.0;
            Hue = 1153;
			Name = "†--Gargish Necklace of White Wolf--†";
			Attributes.SpellDamage = 75;
			Attributes.DefendChance = 15;
			Attributes.AttackChance = 15;
			Attributes.WeaponSpeed = 10;
			Attributes.BonusHits = 45;
			Attributes.BonusMana = 45;
			Attributes.BonusStam = 35;
			Attributes.BonusStr = 35;
			Attributes.BonusDex = 40;
			Attributes.BonusInt = 40;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 12;
			Attributes.LowerRegCost = 20;
			Attributes.ReflectPhysical = 10;
			Attributes.EnhancePotions = 15;
			Attributes.RegenHits = 10;
			Attributes.RegenStam = 10;
			Attributes.RegenMana = 10;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.NightSight = 1;
			Attributes.Luck = 475;
			ColdBonus = 18;
			EnergyBonus = 17;
			FireBonus = 18;
			PoisonBonus = 18;
			PhysicalBonus = 19;
			//Resistances.Cold = 10;
			//Resistances.Energy = 10;
			//Resistances.Fire = 10;
			//Resistances.Physical = 10;
			//Resistances.Poison = 10;
			
			//SkillBonuses.SetValues( 1, SkillName.Carpentry, 5.0 );
			//SkillBonuses.SetValues( 2, SkillName.Fletching, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			//SetVaues( 4, SkillName.Mining, 5.0 );
			//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
			
			LootType = LootType.Blessed;
		}


        public WWGargishNecklace(Serial serial)
            : base(serial)
        {
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