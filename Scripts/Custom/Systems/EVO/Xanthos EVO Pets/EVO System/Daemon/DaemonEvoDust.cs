using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Xanthos.Evo
{
	public class RaelisDaemonDust : BaseEvoDust
	{
		[Constructable]
		public RaelisDaemonDust() : this( 1 )
		{
		}

		[Constructable]
		public RaelisDaemonDust( int amount ) : base( amount )
		{
			Amount = amount;
			Name = "Daemon Dust";
			Hue = 1153;
		}

		public RaelisDaemonDust( Serial serial ) : base ( serial )
		{
		}

		public override BaseEvoDust NewDust()
		{
			return new RaelisDaemonDust();
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