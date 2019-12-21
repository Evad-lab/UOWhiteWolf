using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class LionEvoDust : BaseEvoDust
	{
		[Constructable]
		public LionEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public LionEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Lion Dust";
			Hue = 1153;
		}

		public LionEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new LionEvoDust();
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