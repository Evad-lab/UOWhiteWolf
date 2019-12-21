//Scripted By James4245
using System;
using Server;

namespace Server.Items
{
	public class Glamdring : Broadsword
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Glamdring()
		{
			Name = "Glamdring";
			Hue = 1153;
			
			DurabilityLevel = WeaponDurabilityLevel.Indestructible;
         		Quality = ItemQuality.Exceptional;

				WeaponAttributes.HitLightning = 40;
				WeaponAttributes.HitLeechMana = 60;
				Attributes.BonusMana = 15;
				Attributes.WeaponDamage = 45;
				Attributes.RegenMana = 3;
				Attributes.SpellChanneling = 1;
				Attributes.CastSpeed = 1;
				}



        public Glamdring( Serial serial ) : base( serial )
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
	}
}
