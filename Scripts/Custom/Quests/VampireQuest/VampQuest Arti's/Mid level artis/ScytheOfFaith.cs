  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;
using Server.Engines.Harvest;

namespace Server.Items
{
	[FlipableAttribute( 0x26BA, 0x26C4 )]
	public class ScytheOfFaith : BasePoleArm
	{
		public override int ArtifactRarity{ get{return 85; } }
		
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosStrengthReq{ get{ return 45; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 18; } }
		public override int AosSpeed{ get{ return 32; } }

		public override int OldStrengthReq{ get{ return 45; } }
		public override int OldMinDamage{ get{ return 15; } }
		public override int OldMaxDamage{ get{ return 18; } }
		public override int OldSpeed{ get{ return 32; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override HarvestSystem HarvestSystem{ get{ return null; } }

		[Constructable]
		public ScytheOfFaith() : base( 0x26BA )
		{
			Name = "The Scythe of Faith";
			Hue = 906;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 40;
			Attributes.WeaponDamage = 35;
			Attributes.AttackChance = 15;
			Attributes.DefendChance = 15;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			Weight = 5.0;
			
			SlayerGroup undead = new SlayerGroup();
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
                          case 0: defender.Damage( 33, attacker );
				  defender.FixedParticles( 0x37CC, 1, 40, 97, 3, 9917, 0 ); 
				  attacker.Say( "Lord Defend me from this evil!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public ScytheOfFaith( Serial serial ) : base( serial )
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