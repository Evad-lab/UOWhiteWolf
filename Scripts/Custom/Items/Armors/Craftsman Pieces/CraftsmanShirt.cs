
using System;
using Server.Misc;

namespace Server.Items
{

	public class CraftsmanShirt : Shirt
	{ 
		
		[Constructable] 
		public CraftsmanShirt() : base( 0x1517 ) 
		{ 
            Hue = 1161;		
			Name = "Craftsman Shirt";
			//Attributes.SpellDamage = 15;
			Attributes.DefendChance = 10;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 15;
			Attributes.BonusMana = 15;
			Attributes.BonusStam = 15;
			Attributes.BonusStr = 15;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 15;
			Attributes.LowerRegCost = 20;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 5;
			Attributes.RegenStam = 5;
			Attributes.RegenMana = 5;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 150;
			//ColdBonus = 8;
			//EnergyBonus = 8;
			//FireBonus = 8;
			//PoisonBonus = 8;
			//PhysicalBonus = 8;
			Resistances.Cold = 10;
			Resistances.Energy = 10;
			Resistances.Fire = 10;
			Resistances.Physical = 10;
			Resistances.Poison = 10;
			
			SkillBonuses.SetValues( 1, SkillName.Fletching, 5.0 );
			SkillBonuses.SetValues( 2, SkillName.Carpentry, 5.0 );
			SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
			SkillBonuses.SetValues( 4, SkillName.Mining, 5.0 );
			SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
			Hue = 1161;
		}

       public CraftsmanShirt(Serial serial)
            : base(serial)
        {
		}

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		} 
	} 
} 