using System;
using Server;

namespace Server.Items
{
	public class WWsword : Katana 
	{
		public override int ArtifactRarity{ get{ return 6; } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }

		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

		public override float MlSpeed{ get{ return 2.25f; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public WWsword()
		{
			Weight = 5.0;
            		Name = "Sword of the White Wolf";
            		Hue = 1153;

			WeaponAttributes.HitLightning = 54;
			WeaponAttributes.HitHarm = 48;
			WeaponAttributes.HitLowerDefend = 54;

			Attributes.Luck = 100;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 25;
			Attributes.WeaponDamage = 50;
			Attributes.BonusStr = 10;
			Attributes.BonusDex = 10;
			Attributes.RegenHits = 2;
			

			StrRequirement = 70;

			LootType = LootType.Regular;
		}

		public WWsword ( Serial serial ) : base( serial )
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