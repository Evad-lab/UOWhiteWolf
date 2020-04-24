using System;
using Server;

namespace Server.Items
{
	public class CRightLeg : BaseBodyPart
	{				
		[Constructable]
		public CRightLeg() : base( AccessLevel.GameMaster )
		{
			ItemID = 7601;
		}

		public CRightLeg( Serial serial ) : base( serial )
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
		}
	}
}