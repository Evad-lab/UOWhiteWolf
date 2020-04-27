using System;
using Server.Items;

namespace Server.Items
{

	public class QuiverWW: BaseQuiver
	{		
	

		[Constructable]
		public QuiverWW() : base( 0x2FB7 )
        {
			Name = "† Quiver of White Wolf †";
			Hue = 1153;
            DamageIncrease = 10;
			Attributes.DefendChance = 35;
			Attributes.AttackChance = 35;
			Attributes.BonusDex = 30;
			Attributes.EnhancePotions = 20;
			Attributes.CastRecovery = 6;
			Attributes.CastSpeed = 6;
			Attributes.BonusHits = 30;
			Attributes.BonusInt = 20;
			Attributes.LowerRegCost = 20;
			Attributes.LowerManaCost = 15;
			Attributes.BonusStr = 20;
			Attributes.Luck = 425;
			Attributes.BonusMana = 30;
			Attributes.RegenMana = 15;
			Attributes.RegenHits = 15;
			Attributes.RegenStam = 15;
			Attributes.ReflectPhysical = 15;
			Attributes.SpellDamage = 35;
			Resistances.Cold = 15;
			Resistances.Energy = 15;
			Resistances.Fire = 15;
			Resistances.Physical =15;
			Resistances.Poison = 15; 
			SkillBonuses.SetValues( 0, SkillName.Inscribe, 10.0 );
			LowerAmmoCost = 100;
			WeightReduction = 30;
			
			LootType = LootType.Blessed;
			
		}

		public QuiverWW( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}