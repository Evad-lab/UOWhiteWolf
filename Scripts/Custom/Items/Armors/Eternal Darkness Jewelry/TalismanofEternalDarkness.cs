using System;

namespace Server.Items
{
    public class TalismanofEternalDarkness : BaseTalisman
    {
		
		
        [Constructable]
        public TalismanofEternalDarkness()
            : base(0x2F5A)
        {
			Name = "Talisman of Eternal Darkness";
            Hue = 2498;
			Attributes.SpellDamage = 40;
			Attributes.DefendChance = 20;
			Attributes.WeaponSpeed = 30;
			Attributes.WeaponDamage = 35;
			Attributes.AttackChance = 15;
			Attributes.BonusHits = 25;
			Attributes.BonusMana = 25;
			Attributes.BonusStam = 25;
			Attributes.BonusStr = 25;
			Attributes.BonusDex = 25;
			Attributes.BonusInt = 25;
			Attributes.CastRecovery = 4;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 15;
			Attributes.LowerRegCost = 20;
			Attributes.EnhancePotions = 20;
			Attributes.ReflectPhysical = 20;
			Attributes.RegenHits = 8;
			Attributes.RegenStam = 8;
			Attributes.RegenMana = 8;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 300;
			//ColdBonus = 8;
			//EnergyBonus = 8;
			//FireBonus = 8;
			//PoisonBonus = 8;
			//PhysicalBonus = 8;
			//Resistances.Cold = 5;
			//Resistances.Energy = 5;
			//Resistances.Fire = 5;
			//Resistances.Physical = 5;
			//Resistances.Poison = 5;
			
			SkillBonuses.SetValues( 1, SkillName.Magery, 15.0 );
			//SkillBonuses.SetValues( 2, SkillName.Tailoring, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Imbuing, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.ArmsLore, 5.0 );
        }

        public TalismanofEternalDarkness(Serial serial)
            : base(serial)
        {
        }
        
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}