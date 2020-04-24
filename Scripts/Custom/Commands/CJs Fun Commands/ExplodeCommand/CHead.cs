using System;
using Server;

namespace Server.Items
{
	public class CHead : BaseBodyPart
	{
		[Constructable]
		public CHead() : base( AccessLevel.GameMaster )
		{
			ItemID = 7401;
		}

		public CHead( Serial serial ) : base( serial )
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