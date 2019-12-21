using System;
using Server;

namespace Server.Items
{
	public class GlovesOfKillar : PlateGloves
	{
		public override int ArtifactRarity{ get{ return 20; } }

		public override int ColdResistance{ get{ return 20; } } 

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GlovesOfKillar()
		{
                        Name = "Gloves Of Killar";
 			Hue = 1161;
			Attributes.BonusDex = 10;
			Attributes.BonusInt = 2;
			Attributes.RegenMana = 2;
			//Attributes.WeaponSpeed = 15;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 1;
		}

		public GlovesOfKillar( Serial serial ) : base( serial )
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