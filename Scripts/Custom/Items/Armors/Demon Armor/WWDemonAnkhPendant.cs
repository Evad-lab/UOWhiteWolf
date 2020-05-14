using System;
using Server;
using System.Collections.Generic;
using Server.Regions;

namespace Server.Items
{

    public class WWDemonAnkhPendant : BaseNecklace
    {
		public override int InitMinHits { get { return 0; } }
        public override int InitMaxHits { get { return 0; } }

        [Constructable]
        public WWDemonAnkhPendant()
            : base(0x3BB5)
        {
			Weight = 1.0;
			Name = "Daemon Pendant of the Devil";
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
			Hue = 33;
			
			SkillBonuses.SetValues( 1, SkillName.SpiritSpeak, 10.0 );
			
        }
		
		public WWDemonAnkhPendant(Serial serial)
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