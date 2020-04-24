using System;
using Server;

namespace Server.Items
{
	public class CTorso : BaseBodyPart
	{		
		[Constructable]
		public CTorso() : base( AccessLevel.GameMaster )
		{
			ItemID = 7597;
		}

		public CTorso( Serial serial ) : base( serial )
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