// Scripted by Karmageddon
using System;
using Server;
using Server.Guilds;

namespace Server.Items
{
	public class ArmsofDragon : PlateArms
	{
		public override int ArtifactRarity{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ArmsofDragon()
		{
			Hue = 1157;
			Name = "Sleeves of the Dragon";
			Attributes.RegenStam = 2;
			Attributes.LowerManaCost = 5;
			Attributes.BonusStam = 10;
			Attributes.WeaponDamage = 2;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
			PhysicalBonus = 10;
			FireBonus = 9;
			ColdBonus = 8;
			PoisonBonus = 10;
			EnergyBonus = 7;		
		}

		public ArmsofDragon( Serial serial ) : base( serial )
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
				m.SendMessage( "You feel the power of a dragon embrace you as the arms attach to you!" );

			}
			
			return true;
		}
	}
}
