using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	[CorpseName( "a ferret corpse" )]
	public class Ferret : BaseEvo, IEvoCreature
	{
		public override BaseEvoSpec GetEvoSpec()
		{
			return FerretSpec.Instance;
		}

		public override BaseEvoEgg GetEvoEgg()
		{
			return new FerretEgg();
		}

		public override bool AddPointsOnDamage { get { return true; } }
		public override bool AddPointsOnMelee { get { return false; } }
		public override Type GetEvoDustType() { return typeof( FerretDust ); }

		public override bool HasBreath{ get{ return true; } }

		public Ferret( string name ) : base( name, AIType.AI_Mage, 0.01 )
		{
		}

		public Ferret( Serial serial ) : base( serial )
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