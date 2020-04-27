using System;

namespace Server.Items
{
	public class Blades : Item
	{

		[Constructable]
		public Blades() : base(0x37A0)
		{
			Name = "Field of Blades";
			Movable = true;
			LootType = LootType.Blessed;
		}

		public Blades(Serial serial) : base(serial)
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