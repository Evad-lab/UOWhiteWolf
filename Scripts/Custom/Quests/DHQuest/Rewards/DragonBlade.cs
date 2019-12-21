// Scripted by Karmageddon
using System;
using Server;
using Server.Guilds;

namespace Server.Items
{
	public class DragonBlade : Broadsword
	{
		//public override int LabelNumber{ get{ return 1061088; } } // Blade of Insanity
		public override int ArtifactRarity{ get{ return 20; } }
		public override int AosMinDamage{ get{ return 20; } }
		public override int AosMaxDamage{ get{ return 26; } }
		public override int AosSpeed{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DragonBlade()
		{
			Hue = 1157;
			Name = "Dragon Blade";
			Attributes.CastSpeed = 1;
			//Attributes.CastRecovery = 5;
			//WeaponAttributes.HitLeechStam = 60;
			WeaponAttributes.HitLightning = 40;
			WeaponAttributes.HitLeechMana = 50;
			WeaponAttributes.HitLeechHits = 50;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 50;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = cold = nrgy = chaos = direct = 0;
			fire = 90;
			pois = 10;
		}

		public DragonBlade( Serial serial ) : base( serial )
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
				m.SendMessage( "You feel the power of a dragon run through your blood embrace you as your fingers wrap around the handle!" );

			}
			
			return true;
		}
	}
}