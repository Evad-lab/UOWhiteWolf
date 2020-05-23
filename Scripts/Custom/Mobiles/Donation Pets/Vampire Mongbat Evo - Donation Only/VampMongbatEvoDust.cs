using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class VampMongbatEvoDust : BaseEvoDust
	{
		[Constructable]
		public VampMongbatEvoDust() : this( 1 )
		{
		}

		[Constructable]
		public VampMongbatEvoDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Greater Vampire Mongbat Dust";
			Hue = 1153;
		}

		public VampMongbatEvoDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new VampMongbatEvoDust();
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