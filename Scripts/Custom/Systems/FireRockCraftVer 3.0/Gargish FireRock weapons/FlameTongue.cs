/* Created by Hammerhand */

using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	// Based off a VikingSword
	[FlipableAttribute( 0x900, 0x4071 )]
	public class FlameTongue : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

        public override int Hue { get { return 1359; } }
		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 28; } }
		public override float MlSpeed{ get{ return 3.75f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 6; } }
		public override int OldMaxDamage{ get{ return 34; } }
		public override int OldSpeed{ get{ return 30; } }

		public override int DefHitSound{ get{ return 0x237; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 100; } }

        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

		[Constructable]
		public FlameTongue() : base( 0x900 )
		{
            Name = "FlameTongue";
            Hue = 1359;
			Weight = 6.0;

            WeaponAttributes.BloodDrinker = 1;
            WeaponAttributes.HitHarm = Utility.RandomMinMax(4, 15);
            Attributes.AttackChance = Utility.RandomMinMax(9, 17);
            Attributes.WeaponDamage = Utility.RandomMinMax(6, 14);
            Attributes.BonusStr = Utility.RandomMinMax(4, 9);
            Attributes.WeaponSpeed = Utility.RandomMinMax(7, 12);
            Attributes.SpellChanneling = 1;
            Attributes.RegenHits = Utility.RandomMinMax(4, 7);
            WeaponAttributes.HitFireball = Utility.RandomMinMax(10, 30);
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = Utility.RandomMinMax(9, 16);
            WeaponAttributes.HitCurse = Utility.RandomMinMax(8, 15);
		}
        public override void GetDamageTypes(Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct)
        {
            phys = cold = pois = direct = nrgy = 0;
            chaos = 50;
            fire = 50;
        }
        public FlameTongue(Serial serial)
            : base(serial)
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