// Scripted by Karmageddon
using System;
using Server;
using Server.Guilds;

namespace Server.Items
{
	public class LeggingsofDragon : PlateLegs
	{
		//public override int LabelNumber{ get{ return 1061100; } } // Leggings of Bane
		public override int ArtifactRarity{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LeggingsofDragon()
		{
			Hue = 1157;
			Name = "Leggings of the Dragon";
			//Attributes.BonusStr = 10;
			Attributes.BonusHits = 10;
			Attributes.RegenHits = 2;
			Attributes.WeaponDamage = 10;
			Attributes.WeaponSpeed = 5;
			ArmorAttributes.MageArmor = 1;
			PhysicalBonus = 12;
			FireBonus = 10;
			ColdBonus = 11;
			PoisonBonus = 10;
			EnergyBonus = 9;		
		}

		public LeggingsofDragon( Serial serial ) : base( serial )
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

		public override bool OnEquip( Mobile from )
		{
			return Validate( from ) && base.OnEquip( from );
		}

		public override void OnSingleClick( Mobile from )
		{
			if ( Validate( Parent as Mobile ) )
				base.OnSingleClick( from );
		}

		public bool Validate( Mobile m )
		{
			if ( m == null || !m.Player )
				return true;
			{
				m.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.LeftFoot );
				m.PlaySound( 0x208 );
				m.SendMessage( "You feel the power of a dragon embrace you as the leggings attach to you!" );

			}
			
			return true;
		}
	}
}
