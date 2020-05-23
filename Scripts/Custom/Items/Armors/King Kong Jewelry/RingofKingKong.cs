using System;
using Server;

namespace Server.Items
{
	public class RingofKingKong : GoldRing
	{


		[Constructable]
		public RingofKingKong()
		{
			Name = "Ring of King Kong";
			Hue = 2498;
			Attributes.SpellDamage = 20;
			Attributes.DefendChance = 15;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 15;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 10;
			Attributes.BonusMana = 10;
			Attributes.BonusStam = 10;
			Attributes.BonusStr = 10;
			Attributes.BonusDex = 20;
			Attributes.BonusInt = 10;
			Attributes.CastRecovery = 4;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;
			Attributes.EnhancePotions = 12;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 8;
			Attributes.RegenStam = 8;
			Attributes.RegenMana = 8;
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
			
			SkillBonuses.SetValues( 1, SkillName.Magery, 10.0 );
			//SkillBonuses.SetValues( 2, SkillName.Tailoring, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Imbuing, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.ArmsLore, 5.0 );
			
		
		}

		public RingofKingKong( Serial serial ) : base( serial )
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