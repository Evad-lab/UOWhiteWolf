using System;

namespace Server.Items
{
    [Flipable(0x2684, 0x2683)]
    public class DemonShroudDevil : BaseOuterTorso
	{
        [Constructable]
        public DemonShroudDevil()
            : this(0x455)
        {
		}

        [Constructable]
        public DemonShroudDevil(int hue)
            : base(0x2684, hue)
        {

            Weight = 3.0;
			Name = "Daemon Shroud of the Devil";
			Attributes.SpellDamage = 20;
			Attributes.DefendChance = 5;
			Attributes.AttackChance = 10;
			Attributes.BonusHits = 20;
			Attributes.BonusMana = 20;
			Attributes.BonusDex = 20;
			Attributes.BonusInt = 15;
			Attributes.BonusStam = 20;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 15;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 10;
			Attributes.RegenStam = 10;
			Attributes.RegenMana = 10;
			Attributes.Luck = 150;
			//ColdBonus = 22;
			//EnergyBonus = 22;
			//FireBonus = 23;
			//PoisonBonus = 24;
			//PhysicalBonus = 23;
			
			SkillBonuses.SetValues( 1, SkillName.SpiritSpeak, 10.0 );
			
			Hue = 33;
			
        }

        public DemonShroudDevil(Serial serial)
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