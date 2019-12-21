// Scripted by Karmageddon
using System;
using Server;
using Server.Guilds;

namespace Server.Items
{
	public class GlovesofDragon : PlateGloves
	{
		//public override int LabelNumber{ get{ return 1060206; } } // The Inquisitor's Resolution
		public override int ArtifactRarity{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GlovesofDragon()
		{
			Hue = 1157;
			Name = "Gloves of the Dragon";
			Attributes.BonusInt = 10;
			//Attributes.RegenMana = 7;
			Attributes.WeaponDamage = 20;
			Attributes.AttackChance = 10;
			//Attributes.DefendChance = 20;
			ArmorAttributes.MageArmor = 1;
			PhysicalBonus = 9;
			FireBonus = 10;
			ColdBonus = 10;
			PoisonBonus = 9;
			EnergyBonus = 8;		
		}

		public GlovesofDragon( Serial serial ) : base( serial )
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
				m.SendMessage( "You feel the power of a dragon embrace you as the gloves attach to you!" );

			}
			
			return true;
		}
	}
}
