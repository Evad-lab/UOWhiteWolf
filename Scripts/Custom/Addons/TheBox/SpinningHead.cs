using System;

namespace Server.Items
{
	public class SpinningHead : Item
	{

		[Constructable]
		public SpinningHead() : base(0x1F1F)
		{
			Name = "Spinning Double Head";
			Movable = true;
			LootType = LootType.Blessed;
		}

		public SpinningHead(Serial serial) : base(serial)
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
		}
	}
}