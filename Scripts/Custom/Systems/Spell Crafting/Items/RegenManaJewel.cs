#region AuthorHeader
//
//	SpellCrafting version 3.0, by Xanthos and TheOutkastDev
//
//  Based on original ideas and code by TheOutkastDev
//
#endregion AuthorHeader
using System;
using Server;

namespace Server.SpellCrafting.Items
{
	public class RegenerateManaJewel : BaseSpellCraft
	{
		[Constructable]
		public RegenerateManaJewel() : this( 1 )
		{
		}

		[Constructable]
		public RegenerateManaJewel( int amount ) : base( amount, 12 )
		{
		}

		public RegenerateManaJewel( Serial serial ) : base( serial )
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
			int version = reader.ReadInt(); // version
		}
	}
}
