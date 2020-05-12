using System;

namespace Server.Items
{
    [TypeAlias("Server.Items.MaleGargishPlateChest")]
    public class WWGargishPlateChest : BaseArmor
    {
	
		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }
		
		
        [Constructable]
        public WWGargishPlateChest()
            : this(0)
        {
        }
	

        [Constructable]
        public WWGargishPlateChest(int hue)
            : base(0x30A)
        {
            Weight = 10.0;
            Hue = 1153;
			LootType = LootType.Blessed;
			Name = "†--Gargish Tunic of White Wolf--†";
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
			ArmorAttributes.MageArmor = 1;
			Attributes.NightSight = 1;
			Attributes.Luck = 475;
			ColdBonus = 15;
			EnergyBonus = 15;
			FireBonus = 14;
			PoisonBonus = 14;
			PhysicalBonus = 12;
			
			//SkillBonuses.SetValues( 1, SkillName.Carpentry, 5.0 );
			//SkillBonuses.SetValues( 2, SkillName.Fletching, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			//SetVaues( 4, SkillName.Mining, 5.0 );
			//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
        }

        public WWGargishPlateChest(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance { get { return 8; } }
        public override int BaseFireResistance { get { return 6; } }
        public override int BaseColdResistance { get { return 5; } }
        public override int BasePoisonResistance { get { return 6; } }
        public override int BaseEnergyResistance { get { return 5; } }

        public override int AosStrReq { get { return 95; } }

        public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Plate; } }

        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

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