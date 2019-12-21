  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;

namespace Server.Items
{
	public class MaceOfHell : WarMace
	{
		public override int ArtifactRarity{ get{return 85; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MaceOfHell()
		{
			ItemID = 5127;
			Name = "Hells Might";
			Hue = 49;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 30;
			Attributes.WeaponDamage = 60;
			Attributes.AttackChance = 10;
			Attributes.DefendChance = 10;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitFireArea = 35;
			Weight = 5.0;
		
			SlayerGroup abyss = new SlayerGroup();
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
                          case 0: defender.Damage( 27, attacker );
				  defender.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.LeftFoot ); 
				  attacker.Say( "Feel the hate Hell holds for you!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public MaceOfHell( Serial serial ) : base( serial )
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