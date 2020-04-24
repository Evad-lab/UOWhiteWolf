using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	public class CuSidheEvoEgg : BaseEvoEgg
	{
		public override IEvoCreature GetEvoCreature()
		{
			return new EvoCuSidhe( "a Cu Sidhe hatchling" );
		}

		[Constructable]
		public CuSidheEvoEgg() : base()
		{
			Name = "a Cu Sidhe egg";
			HatchDuration = 0.01;		// 15 minutes
		}

		public CuSidheEvoEgg( Serial serial ) : base ( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}