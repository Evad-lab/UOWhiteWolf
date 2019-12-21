#region References

using Server.Gumps;

#endregion

namespace Server.Items
{
	public class HueCenterGold : Item
	{
		[Constructable]
		public HueCenterGold() : base(0xED4)
		{
			Movable = false;
			Name = "The Hue Center (Cost in Gold)";
		}

		public HueCenterGold(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write(0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}

		public override void OnDoubleClick(Mobile from)
		{
			if (from.InRange(GetWorldLocation(), 2))
			{
				from.SendGump(new HueListGumpGold(from, 0));
			}
			else
			{
				from.SendLocalizedMessage(500446); // That is too far away.
			}
		}
	}
}