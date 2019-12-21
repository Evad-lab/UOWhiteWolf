  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;

namespace Server.Items
{

	public class FistsOfPainandFury : Club
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public FistsOfPainandFury()
		{
			ItemID = 5062;
			Name = "Fists of Pain and Fury";
			Hue = 295;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 40;
			Attributes.WeaponDamage = 60;
			Attributes.AttackChance = 20;
			Attributes.RegenHits = 5;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			WeaponAttributes.HitLightning = 50;
			WeaponAttributes.HitEnergyArea = 30;
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
                          case 0: defender.Damage( 32, attacker );
				  defender.FixedParticles( 0x37CC, 1, 40, 97, 3, 9917, 0 ); 
				  attacker.Say( "Suffer my fury!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public FistsOfPainandFury( Serial serial ) : base( serial )
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