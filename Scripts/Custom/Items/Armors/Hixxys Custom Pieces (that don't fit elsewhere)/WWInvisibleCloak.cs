using System;
using Server.Engines.Craft;

namespace Server.Items
{

    public class WWInvisibleCloak : Cloak
	{

        [Constructable]
        public WWInvisibleCloak()
        {
			Name = "White Wolf's Invisible Cloak";
			//Attributes.SpellDamage = 20;
			//Attributes.DefendChance = 5;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 10;
			//Attributes.BonusDex = 20;
			//Attributes.BonusInt = 15;
			Attributes.BonusStam = 10;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 15;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 3;
			Attributes.RegenStam = 3;
			Attributes.RegenMana = 3;
			Attributes.Luck = 100;
			//ColdBonus = 22;
			//EnergyBonus = 22;
			//FireBonus = 23;
			//PoisonBonus = 24;
			//PhysicalBonus = 23;
			Resistances.Cold = 10;
			Resistances.Energy = 10;
			Resistances.Fire = 10;
			Resistances.Physical = 10;
			Resistances.Poison = 10;
			
			SkillBonuses.SetValues( 1, SkillName.Hiding, 10.0 );
			
			Hue = 1153;
        }

        public WWInvisibleCloak(Serial serial)
            : base(serial)
        {
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

    public class WWGargishInvisibleWingArmor : GargishClothWingArmor
    {

        [Constructable]
        public WWGargishInvisibleWingArmor()
        {
            Name = "White Wolf's Gargish Invisible Cloak";
			//Attributes.SpellDamage = 20;
			//Attributes.DefendChance = 5;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 10;
			//Attributes.BonusDex = 20;
			//Attributes.BonusInt = 15;
			Attributes.BonusStam = 10;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 15;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 3;
			Attributes.RegenStam = 3;
			Attributes.RegenMana = 3;
			Attributes.Luck = 100;
			//ColdBonus = 22;
			//EnergyBonus = 22;
			//FireBonus = 23;
			//PoisonBonus = 24;
			//PhysicalBonus = 23;
			Resistances.Cold = 10;
			Resistances.Energy = 10;
			Resistances.Fire = 10;
			Resistances.Physical = 10;
			Resistances.Poison = 10;
			
			SkillBonuses.SetValues( 1, SkillName.Hiding, 10.0 );
			
			Hue = 1153;
        }

        public WWGargishInvisibleWingArmor(Serial serial)
            : base(serial)
        {
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