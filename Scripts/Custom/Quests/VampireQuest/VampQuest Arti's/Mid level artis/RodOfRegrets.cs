  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;

namespace Server.Items
{
	
	public class RodOfRegrets : QuarterStaff
	{
		public override int ArtifactRarity{ get{return 85; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RodOfRegrets()
		{
			ItemID = 3721;
			Name = "Rod Of Regrets";
			Hue = 1055;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 25;
			Attributes.WeaponDamage = 45;
			Attributes.AttackChance = 10;
			Attributes.DefendChance = 10;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			WeaponAttributes.HitLeechMana = 50;
			Weight = 5.0;
		}
		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			double damage = 0.0;

			PlaySwingAnimation( attacker );
			PlayHurtAnimation( defender );

			attacker.PlaySound( GetHitAttackSound( attacker, defender ) );
			defender.PlaySound( GetHitDefendSound( attacker, defender ) );

			switch ( Utility.Random( 5 ) )
                        { 
                          	case 0: defender.Damage( 55, attacker );
				attacker.Damage( 35, defender );
				defender.FixedParticles( 0x373A, 10, 15, 5012, EffectLayer.Waist ); 
				attacker.Say( "Why must I endure this!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public RodOfRegrets( Serial serial ) : base( serial )
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

			if ( Weight == 15.0 )
				Weight = 5.0;
		}
	}
}