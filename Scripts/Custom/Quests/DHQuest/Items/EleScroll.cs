// Scripted by Karmageddon
using System;

namespace Server.Items
{
	public class EleSummonScroll : Item
	{		
		[Constructable]
		public EleSummonScroll() : base( 0x227A )
		{
			Name = "Scroll of Elemental Summoning";			
			Weight = 0.1;						
		}

		public EleSummonScroll( Serial serial ) : base( serial )
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