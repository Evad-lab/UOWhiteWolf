using System;

namespace Server.Items
{
    [FlipableAttribute(0x144e, 0x1453)]
    public class WWDemonBoneArms : BaseArmor
    {
		public override int BasePhysicalResistance { get { return 3; } }
        public override int BaseFireResistance { get { return 3; } }
        public override int BaseColdResistance { get { return 4; } }
        public override int BasePoisonResistance { get { return 2; } }
        public override int BaseEnergyResistance { get { return 4; } }
        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }
        public override int AosStrReq { get { return 55; } }
        public override int OldStrReq { get { return 40; } }
		public override int OldDexBonus { get { return -2; } }
        public override int ArmorBase { get { return 30; } }
        public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Bone; } }
		public override CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }
		
        [Constructable]
        public WWDemonBoneArms()
            : base(0x144E)
        {
            Weight = 2.0;
			Name = "Daemon Arms of the Devil";
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
			ArmorAttributes.SelfRepair = 2;
			ArmorAttributes.MageArmor = 1;
			Attributes.Luck = 150;
			ColdBonus = 22;
			EnergyBonus = 22;
			FireBonus = 23;
			PoisonBonus = 24;
			PhysicalBonus = 23;
			Hue = 33;
			
			SkillBonuses.SetValues( 1, SkillName.SpiritSpeak, 10.0 );
        }

        public WWDemonBoneArms(Serial serial)
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