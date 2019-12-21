using System;
using Server;

namespace Server.Items
{
	public class TheRingOfEurystheus : GoldRing
	{
		public override int ArtifactRarity{ get{ return 11; } }

		[Constructable]
		public TheRingOfEurystheus()
		{
			Name = "The Ring of Eurystheus";
			Attributes.BonusStr = 5;
			Attributes.BonusDex = 5;
			Attributes.BonusInt = 5;
			Attributes.Luck = 50;
			Attributes.NightSight = 1;
			Attributes.CastRecovery = 3;
			Attributes.CastSpeed = 1;
			Attributes.WeaponSpeed = 10;
			Resistances.Cold = 15;
		}

		public TheRingOfEurystheus( Serial serial ) : base( serial )
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