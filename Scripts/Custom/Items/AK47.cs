using System;
using Server;

namespace Server.Items
{
	public class AKForty : Crossbow
	{

		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }


		[Constructable]
		public AKForty()
		{
			Name = "†--AK-47--†";
			ItemID = 3920;
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
			SkillBonuses.SetValues( 0, SkillName.Archery, 10.0 );
			Attributes.Luck = 250;
			MaxRange = 15;
			Hue = 1153;
			MaxDamage = 33;
			MinDamage = 25;
			
			LootType = LootType.Blessed;
			

		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 4410, 3, 3, false, false );
			base.OnHit( attacker, defender );
		}
		public AKForty( Serial serial ) : base( serial )
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