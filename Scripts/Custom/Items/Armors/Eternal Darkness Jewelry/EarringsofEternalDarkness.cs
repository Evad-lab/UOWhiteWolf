using System;
using Server;

namespace Server.Items
{
	public class EarringsofEternalDarkness : GoldEarrings
	{


		[Constructable]
		public EarringsofEternalDarkness()
		{
			Name = "Earrings Of Eternal Darkness";
			Hue = 2498;
			Attributes.SpellDamage = 40;
			Attributes.DefendChance = 15;
			Attributes.WeaponSpeed = 20;
			Attributes.WeaponDamage = 25;
			Attributes.AttackChance = 15;
			Attributes.BonusHits = 25;
			Attributes.BonusMana = 25;
			Attributes.BonusStam = 25;
			Attributes.BonusStr = 15;
			Attributes.BonusDex = 25;
			Attributes.BonusInt = 15;
			Attributes.CastRecovery = 4;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 15;
			Attributes.LowerRegCost = 15;
			Attributes.EnhancePotions = 25;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 5;
			Attributes.RegenStam = 5;
			Attributes.RegenMana = 5;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 175;
			//ColdBonus = 8;
			//EnergyBonus = 8;
			//FireBonus = 8;
			//PoisonBonus = 8;
			//PhysicalBonus = 8;
			Resistances.Cold = 5;
			Resistances.Energy = 5;
			Resistances.Fire = 5;
			Resistances.Physical = 5;
			Resistances.Poison = 5;
			
			SkillBonuses.SetValues( 1, SkillName.Magery, 5.0 );
			//SkillBonuses.SetValues( 2, SkillName.Tailoring, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Imbuing, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.ArmsLore, 5.0 );
			
		
		}

		public EarringsofEternalDarkness( Serial serial ) : base( serial )
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