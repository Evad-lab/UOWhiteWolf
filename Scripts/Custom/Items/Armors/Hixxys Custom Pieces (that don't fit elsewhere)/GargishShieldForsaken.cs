/* Created by Hammerhand*/

using System;
using Server;

namespace Server.Items
{
	public class GargishShieldForsaken : BaseShield
	{
        public override int Hue { get { return 1152; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int AosStrReq{ get{ return 90; } }

		public override int ArmorBase{ get{ return 23; } }
        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }


		[Constructable]
        public GargishShieldForsaken()
            : base(0x4204)
		{
            
			Weight = 6.0;
			Name = "Shield of the Forsaken";
			Hue = 1152;
			Attributes.SpellDamage = 35;
			Attributes.DefendChance = 30;
			//Attributes.WeaponSpeed = 20;
			//Attributes.WeaponDamage = 25;
			Attributes.AttackChance = 30;
			Attributes.BonusHits = 15;
			Attributes.BonusMana = 15;
			Attributes.BonusStam = 15;
			//Attributes.BonusStr = 15;
			Attributes.BonusDex = 20;
			//Attributes.BonusInt = 15;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;			
			//Attributes.EnhancePotions = 25;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 7;
			Attributes.RegenStam = 7;
			Attributes.RegenMana = 7;
			Attributes.SpellChanneling = 1;
			ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 100;
			ColdBonus =15;
			EnergyBonus = 15;
			FireBonus = 14;
			PoisonBonus = 15;
			PhysicalBonus = 10;
			//Resistances.Cold = 5;
			//Resistances.Energy = 5;
			//Resistances.Fire = 5;
			//Resistances.Physical = 5;
			//Resistances.Poison = 5;
			
			SkillBonuses.SetValues( 1, SkillName.Parry, 20.0 );
			//SkillBonuses.SetValues( 2, SkillName.Tailoring, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Imbuing, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.ArmsLore, 5.0 );

            
		}

        public GargishShieldForsaken(Serial serial)
            : base(serial)
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );//version
		}
	}
}
