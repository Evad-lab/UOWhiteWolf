using System;

namespace Server.Items
{
    public class TalismanofKingKong : BaseTalisman
    {
		
		
        [Constructable]
        public TalismanofKingKong()
            : base(0x2F5A)
        {
			Name = "Talisman of King Kong";
            Hue = 2498;
			Layer = Layer.Talisman;
			Attributes.SpellDamage = 40;
			Attributes.DefendChance = 20;
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
			Attributes.RegenHits = 10;
			Attributes.RegenStam = 10;
			Attributes.RegenMana = 10;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 150;
			
			
			SkillBonuses.SetValues( 1, SkillName.Magery, 10.0 );
			//SkillBonuses.SetValues( 2, SkillName.Tailoring, 5.0 );
			//SkillBonuses.SetValues( 3, SkillName.Imbuing, 5.0 );
			//SkillBonuses.SetValues( 4, SkillName.ArmsLore, 5.0 );
        }

        public TalismanofKingKong(Serial serial)
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