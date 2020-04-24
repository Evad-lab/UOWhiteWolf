using System;
using Server;

namespace Server.Items
{
	public class ChampionDoubleAxeWW : DoubleAxe
	{

		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }


		[Constructable]
		public ChampionDoubleAxeWW()
		{
			Name = "†True Champion Double Axe of White Wolf†";
			ItemID = 3915;
			Attributes.WeaponDamage = 75;
			Attributes.WeaponSpeed = 50;
			WeaponAttributes.HitFireArea = 75;
			WeaponAttributes.HitPhysicalArea = 75;
			WeaponAttributes.HitPoisonArea = 75;
			WeaponAttributes.HitLeechStam = 65;
			WeaponAttributes.HitLeechHits = 65;
			WeaponAttributes.HitLeechMana = 65;
			WeaponAttributes.HitLowerAttack = 65;
			WeaponAttributes.HitLowerDefend = 65;
			WeaponAttributes.SelfRepair = 10;
			Attributes.SpellChanneling = 1;
			Attributes.Luck = 500;
			MaxRange = 3;
			Hue = 1166;
			MaxDamage = 33;
			MinDamage = 25;
			
			LootType = LootType.Blessed;
			

		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 4410, 3, 3, false, false );
			base.OnHit( attacker, defender );
		}
		public ChampionDoubleAxeWW( Serial serial ) : base( serial )
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