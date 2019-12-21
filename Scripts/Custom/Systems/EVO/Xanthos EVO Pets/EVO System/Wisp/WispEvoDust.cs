using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class WispEvoDust : BaseEvoDust
	{
		[Constructable]
		public WispEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public WispEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Wisp Dust";
			Hue = 1153;
		}

		public WispEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new WispEvoDust();
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