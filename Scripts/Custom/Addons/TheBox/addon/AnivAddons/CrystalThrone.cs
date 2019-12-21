using System;
using Server.Items;

namespace Server.Items
{
	[Furniture]
	[FlipableAttribute(0x35ED, 0x35EE)]
	public class CrystalThrone : Item
	{
		[Constructable]
		public CrystalThrone() : base(0x35ED)
		{
			Movable = true;
			Weight = 20.0;
		}

		public CrystalThrone(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}
}