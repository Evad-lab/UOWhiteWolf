using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class FairyDragonDust : BaseEvoDust
	{
		[Constructable]
		public FairyDragonDust() : this( 1 )
		{
		}

		[Constructable]
		public FairyDragonDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Fairy Dragon Dust";
			Hue = 1153;
		}

		public FairyDragonDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new FairyDragonDust();
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