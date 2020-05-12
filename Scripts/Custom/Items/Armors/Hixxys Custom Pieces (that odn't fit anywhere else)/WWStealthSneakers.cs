using System;
using Server;

namespace Server.Items
{

        public class WWStealthSneakers : Shoes
        {
                
				[Constructable]
				public WWStealthSneakers()
				{

				Weight = 1.0;
				Name = "White Wolf's Stealth Sneakers";
				//Attributes.SpellDamage = 15;
				Attributes.DefendChance = 10;
				Attributes.AttackChance = 10;
				Attributes.BonusHits = 10;
				Attributes.BonusMana = 10;
				Attributes.BonusStam = 10;
				Attributes.BonusStr = 15;
				Attributes.CastRecovery = 2;
				Attributes.CastSpeed = 2;
				Attributes.LowerManaCost = 10;
				Attributes.LowerRegCost = 10;
				Attributes.ReflectPhysical = 10;
				Attributes.RegenHits = 5;
				Attributes.RegenStam = 5;
				Attributes.RegenMana = 5;
				//ArmorAttributes.SelfRepair = 5;
				//ArmorAttributes.MageArmor = 1;
				Attributes.Luck = 100;
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
			
				SkillBonuses.SetValues( 1, SkillName.Stealth, 10.0 );
				//SkillBonuses.SetValues( 2, SkillName.Carpentry, 5.0 );
				//SkillBonuses.SetValues( 3, SkillName.Tinkering, 5.0 );
				//SkillBonuses.SetValues( 4, SkillName.Mining, 5.0 );
				//SkillBonuses.SetValues( 5, SkillName.Lumberjacking, 5.0 );
				Hue = 1153;
				}

                public WWStealthSneakers( Serial Serial ) : base ( Serial )
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
                        