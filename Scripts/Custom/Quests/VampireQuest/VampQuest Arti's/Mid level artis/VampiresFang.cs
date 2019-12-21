  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;

namespace Server.Items
{

	public class VampiresFang : Scimitar
	{
		public override int ArtifactRarity{ get{return 85; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public VampiresFang()
		{
			ItemID = 5046;
			Name = "Fang of the Vampire";
			Hue = 39;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 30;
			Attributes.WeaponDamage = 50;
			Attributes.AttackChance = 35;
			Attributes.DefendChance = -10;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			WeaponAttributes.HitLeechHits = 60;
			WeaponAttributes.HitLeechStam = 30;
			Weight = 5.0;
			
			SlayerGroup humanoid = new SlayerGroup();
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
                          case 0: defender.Damage( 35, attacker );
				  defender.FixedParticles( 0x374A, 10, 15, 5013, 0x496, 0, EffectLayer.Waist ); 
				  attacker.Say( "Sacrafice your life to me!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public VampiresFang( Serial serial ) : base( serial )
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