// Scripted by Karmageddon
using System;

namespace Server.Items
{
	public class DragonSummonScroll : Item
	{
		[Constructable]
		public DragonSummonScroll() : base( 0x2274 )
		{
			Name = "Scroll of Dragon Summoning";
			Weight = 0.1;						
		}

		public DragonSummonScroll( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}