using System;
using Server.Mobiles;

namespace Server.Items
{
    public class DaemonTalismanDevil : BaseTalisman
    {
      

        [Constructable]
        public DaemonTalismanDevil()
            : base(0x2F58)
        {
			Name = "Daemon Talisman of the Devil";
            Hue = 33;
			Layer = Layer.Talisman;
			Attributes.SpellDamage = 20;
			Attributes.DefendChance = 15;
			//Attributes.WeaponSpeed = 10;
			//Attributes.WeaponDamage = 15;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 15;
			Attributes.BonusMana = 15;
			Attributes.BonusStam = 15;
			Attributes.BonusStr = 15;
			Attributes.BonusDex = 25;
			Attributes.BonusInt = 10;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 15;
			Attributes.EnhancePotions = 12;
			Attributes.ReflectPhysical = 10;
			Attributes.RegenHits = 7;
			Attributes.RegenStam = 7;
			Attributes.RegenMana = 7;
			//ArmorAttributes.SelfRepair = 5;
			//ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 250;
			
			
			SkillBonuses.SetValues( 1, SkillName.SpiritSpeak, 10.0 );
        }

        public DaemonTalismanDevil(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}