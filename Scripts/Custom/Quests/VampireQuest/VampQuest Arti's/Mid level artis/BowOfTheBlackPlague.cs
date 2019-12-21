  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server.Network;
using Server.Items;
using Server.Spells;


namespace Server.Items
{

	public class BowOfTheBlackPlague : RepeatingCrossbow
	{
		public override int ArtifactRarity{ get{return 85; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public BowOfTheBlackPlague()
		{
			ItemID = 9923;
			Name = "Black Plague";
			Hue = 1150;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 35;
			Attributes.WeaponDamage = 30;
			Attributes.AttackChance = 25;
			Attributes.RegenMana = 5;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			Attributes.SpellDamage = 25;
			Weight = 5.0;
		}
        public virtual void OnHit(Mobile attacker, Mobile defender)
		{
			double damage = 0.0;

			PlaySwingAnimation( attacker );
			PlayHurtAnimation( defender );

			attacker.PlaySound( GetHitAttackSound( attacker, defender ) );
			defender.PlaySound( GetHitDefendSound( attacker, defender ) );

			switch ( Utility.Random( 5 ) )
                        { 
                          case 0: defender.Damage( 37, attacker );
				  defender.FixedParticles( 0x3789, 10, 25, 5032, EffectLayer.Head ); 
				  attacker.Say( "Death will Always Triumph!!!" ); break;
                        }

			SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

		
			base.OnHit( attacker, defender );
		}
	
		public BowOfTheBlackPlague( Serial serial ) : base( serial )
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