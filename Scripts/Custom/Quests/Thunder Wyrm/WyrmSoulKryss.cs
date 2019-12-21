using System;
using Server.Network;
using Server;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x1401, 0x1400 )]
	public class WyrmSoulKryss : BaseSword 
	{
		public override int ArtifactRarity{ get{ return 11; } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }
		//public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.BleedAttack; } }

		public override int AosMinDamage{ get{ return 18; } }
		public override int AosMaxDamage{ get{ return 22; } }
		public override int AosSpeed{ get{ return 56; } }
		public override float MlSpeed{ get{ return 2.50f; } }

		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }

		public override SkillName DefSkill{ get{ return SkillName.Fencing; } }
		public override WeaponType DefType{ get{ return WeaponType.Piercing; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Pierce1H; } }
		
		[Constructable]
		public WyrmSoulKryss() : base( 0x1401 )
		{
			Weight = 2.0;
            		Name = "a Wyrm Soul's Kryss";
            		Hue = 1154;
                         
			WeaponAttributes.HitLightning = 60;
		//	WeaponAttributes.HitLeechHits = 52;
			WeaponAttributes.HitLeechMana = 46;
		//	WeaponAttributes.HitLightning = 58;
		//	WeaponAttributes.HitLowerDefend = 47;
			WeaponAttributes.SelfRepair = 10;

			Attributes.SpellChanneling = 1;
			Attributes.BonusStr = 15;
			Attributes.Luck = 120;
			Attributes.WeaponDamage = 55;
			Attributes.WeaponSpeed = 20;

			DexRequirement = 35;

			LootType = LootType.Blessed;
		}

		public WyrmSoulKryss( Serial serial ) : base( serial )
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

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}