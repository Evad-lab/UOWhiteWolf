using System;

namespace Server.Items
{
    [FlipableAttribute(0x4228, 0x4229)]
    public class WWGargishChaosShield : BaseShield
    {
		public override int BasePhysicalResistance { get { return 1; } }
        public override int BaseFireResistance { get { return 0; } }
        public override int BaseColdResistance { get { return 0; } }
        public override int BasePoisonResistance { get { return 0; } }
        public override int BaseEnergyResistance { get { return 0; } }
        public override int AosStrReq { get { return 95; } }
        public override int ArmorBase { get { return 32; } }
		public override bool CanBeWornByGargoyles { get { return true; } }
        public override Race RequiredRace { get { return Race.Gargoyle; } }
		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }
		
        [Constructable]
        public WWGargishChaosShield()
            : base(0x4228)
        {           
            Weight = 5.0;
			Hue = 1153;
			Name = "†--Gargish Shield of White Wolf--†";
			Attributes.SpellDamage = 35;
			Attributes.DefendChance = 30;
			Attributes.AttackChance = 30;
			Attributes.WeaponSpeed = 10;
			Attributes.BonusHits = 35;
			Attributes.BonusMana = 15;
			Attributes.BonusStam = 15;
			Attributes.BonusStr = 35;
			Attributes.BonusDex = 40;
			Attributes.BonusInt = 30;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;
			Attributes.ReflectPhysical = 15;
			Attributes.EnhancePotions = 15;
			Attributes.RegenHits = 10;
			Attributes.RegenStam = 10;
			Attributes.RegenMana = 10;
			//ArmorAttributes.SelfRepair = 5;
			Attributes.SpellChanneling = 1;
			Attributes.NightSight = 1;
			Attributes.Luck = 475;
			ColdBonus = 25;
			EnergyBonus = 25;
			FireBonus = 25;
			PoisonBonus = 25;
			PhysicalBonus = 24;
			//Resistances.Cold = 10;
			//Resistances.Energy = 10;
			//Resistances.Fire = 10;
			//Resistances.Physical = 10;
			//Resistances.Poison = 10;
			
			SkillBonuses.SetValues( 1, SkillName.Parry, 20.0 );
			//SkillBonuses.SetValues( 2, SkillName.Fletching, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			//SetVaues( 4, SkillName.Mining, 5.0 );
			//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
			
			LootType = LootType.Blessed;
        }

        public WWGargishChaosShield(Serial serial)
            : base(serial)
        {
        }
              
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);//version
        }      
    }
}