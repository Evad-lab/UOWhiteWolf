using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	public class FairyDragonEgg : BaseEvoEgg
	{
		public override IEvoCreature GetEvoCreature()
		{
			return new FairyDragon( "a fairy dragon hatchling" );
		}

		[Constructable]
		public FairyDragonEgg() : base()
		{
			Name = "a fairy dragon egg";
			HatchDuration = 0.01;		// 15 minutes
		}

		public FairyDragonEgg( Serial serial ) : base ( serial )
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