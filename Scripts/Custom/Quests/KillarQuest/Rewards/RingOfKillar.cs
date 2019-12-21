using System;
using Server;

namespace Server.Items
{
	public class RingOfKillar : GoldRing
	{

		public override int ArtifactRarity{ get{ return 20; } }

		[Constructable]
		public RingOfKillar()
		{
			Name = "Ring Of Killar";
			Hue = 1161;
			
			Attributes.RegenHits = 3;
			Attributes.BonusInt = 5;
			Attributes.RegenMana = 2;
			Attributes.BonusStr = 5;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 1;

			Resistances.Fire = 15;
		
		}

		public RingOfKillar( Serial serial ) : base( serial )
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