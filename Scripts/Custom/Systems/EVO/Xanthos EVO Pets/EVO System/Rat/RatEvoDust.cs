using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class RatEvoDust : BaseEvoDust
	{
		[Constructable]
		public RatEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public RatEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Rat Dust";
			Hue = 1153;
		}

		public RatEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new RatEvoDust();
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