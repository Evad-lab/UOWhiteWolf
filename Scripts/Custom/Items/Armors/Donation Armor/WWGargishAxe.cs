using System;

namespace Server.Items
{
    //Based off Axe
    [FlipableAttribute(0x48B2, 0x48B3)]
    public class WWGargishAxe : BaseAxe
    {
		
		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }
		
        [Constructable]
        public WWGargishAxe()
            : base(0x48B2)
        {
			
			Name = "†--True Champion Gargish Double Axe--†";
            this.Weight = 4.0;
			Layer = Layer.OneHanded;
			Attributes.WeaponDamage = 75;
			Attributes.WeaponSpeed = 50;
			Attributes.AttackChance = 15;
			Attributes.LowerAmmoCost = 10;
			WeaponAttributes.HitPhysicalArea = 75;
			WeaponAttributes.HitFireArea = 75;
			WeaponAttributes.HitPoisonArea = 75;
			WeaponAttributes.HitLeechStam = 65;
			WeaponAttributes.HitLeechHits = 65;
			WeaponAttributes.HitLeechMana = 65;
			WeaponAttributes.HitLowerAttack = 65;
			WeaponAttributes.HitLowerDefend = 65;
			WeaponAttributes.SelfRepair = 10;
			Attributes.SpellChanneling = 1;
			//SkillBonuses.SetValues( 0, SkillName.Archery, 10.0 );
			Attributes.Luck = 500;
			MaxRange = 3;
			Hue = 1166;
			MaxDamage = 33;
			MinDamage = 25;
			
			LootType = LootType.Blessed;
			
			
        }

        public WWGargishAxe(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.CrushingBlow;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.Dismount;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 35;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 14;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 17;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 37;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 3.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 35;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 6;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 33;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 37;
            }
        }
        public override Race RequiredRace
        {
            get
            {
                return Race.Gargoyle;
            }
        }
        public override bool CanBeWornByGargoyles
        {
            get
            {
                return true;
            }
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