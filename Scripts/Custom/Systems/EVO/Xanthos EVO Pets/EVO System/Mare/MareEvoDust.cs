using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class MareEvoDust : BaseEvoDust
	{
		[Constructable]
		public MareEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public MareEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Mare Dust";
			Hue = 1153;
		}

		public MareEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new MareEvoDust();
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