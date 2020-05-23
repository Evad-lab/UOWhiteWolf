using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	public class VampMongbatEvoEgg : BaseEvoEgg
	{
		public override IEvoCreature GetEvoCreature()
		{
			return new EvoVampMongbat( "a Greater Vampire Mongbat hatchling" );
		}

		[Constructable]
		public VampMongbatEvoEgg() : base()
		{
			Name = "a Greater Vampire Mongbat egg";
			HatchDuration = 0.01;		// 15 minutes
		}

		public VampMongbatEvoEgg( Serial serial ) : base ( serial )
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