using System;
using Server;

namespace Server.Items
{
	public class CLeftArm : BaseBodyPart
	{
		[Constructable]
		public CLeftArm() : base( AccessLevel.GameMaster )
		{
			ItemID = 7600;
		}

		public CLeftArm( Serial serial ) : base( serial )
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