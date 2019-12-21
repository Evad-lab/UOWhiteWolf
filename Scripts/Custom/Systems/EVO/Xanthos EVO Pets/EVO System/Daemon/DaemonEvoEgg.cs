using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	public class RaelisDaemonEgg : BaseEvoEgg
	{
		public override IEvoCreature GetEvoCreature()
		{
			return new RaelisDaemon( "a Daemon hatchling" );
		}

		[Constructable]
		public RaelisDaemonEgg() : base()
		{
			Name = "a Daemon egg";
			HatchDuration = 0.01;		// 15 minutes
			Hue = 43;
		}

		public RaelisDaemonEgg( Serial serial ) : base ( serial )
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