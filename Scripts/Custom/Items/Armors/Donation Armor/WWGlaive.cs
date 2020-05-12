using System;

namespace Server.Items
{
    public class WWGlaive : BaseThrown
    {
		
		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }
		
        [Constructable]
        public WWGlaive()
            : base(0x090A)
        {
			
			Name = "†--AK-47 Warglaive--†";
            Weight = 8.0;
            Layer = Layer.OneHanded;
			Attributes.WeaponDamage = 50;
			Attributes.WeaponSpeed = 40;
			Attributes.AttackChance = 15;
			Attributes.LowerAmmoCost = 10;
			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitLightning = 50;
			WeaponAttributes.HitLeechStam = 60;
			WeaponAttributes.HitLeechHits = 43;
			WeaponAttributes.HitLeechMana = 43;
			WeaponAttributes.HitLowerAttack = 65;
			WeaponAttributes.HitLowerDefend = 65;
			WeaponAttributes.SelfRepair = 10;
			Attributes.SpellChanneling = 1;
			SkillBonuses.SetValues( 0, SkillName.Throwing, 10.0 );
			Attributes.Luck = 250;
			MaxRange = 15;
			Hue = 1153;
			MaxDamage = 33;
			MinDamage = 25;
			
			LootType = LootType.Blessed;
			
        }

        public WWGlaive(Serial serial)
            : base(serial)
        {
        }

        public override int MinThrowRange { get { return 8; } }

        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.ArmorIgnore;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.MortalStrike;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 60;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 16;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 20;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 25;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 4.00f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 20;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 9;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 41;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 20;
            }
        }

        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }


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
