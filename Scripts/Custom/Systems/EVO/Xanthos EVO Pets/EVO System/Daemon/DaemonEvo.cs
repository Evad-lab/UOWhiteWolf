using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	[CorpseName( "a Daemon corpse" )]
	public class RaelisDaemon : BaseEvo, IEvoCreature
	{
		public override BaseEvoSpec GetEvoSpec()
		{
			return RaelisDaemonSpec.Instance;
		}

		public override BaseEvoEgg GetEvoEgg()
		{
			return new RaelisDaemonEgg();
		}

		public override bool AddPointsOnDamage { get { return true; } }
		public override bool AddPointsOnMelee { get { return false; } }
		public override Type GetEvoDustType() { return typeof( RaelisDaemonDust ); }

		public override bool HasBreath{ get{ return true; } }

		public RaelisDaemon( string name ) : base( name, AIType.AI_Mage, 0.01 )
		{
		}

		public RaelisDaemon( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write( (int)0 );			
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}