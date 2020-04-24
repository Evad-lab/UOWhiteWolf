using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class FerretDust : BaseEvoDust
	{
		[Constructable]
		public FerretDust() : this( 1 )
		{
		}

		[Constructable]
		public FerretDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Ferret Dust";
			Hue = 1153;
		}

		public FerretDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new FerretDust();
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