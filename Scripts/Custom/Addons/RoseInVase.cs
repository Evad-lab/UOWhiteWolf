using System;

namespace Server.Items
{
	
	[Furniture]
	public class RoseInVase : Item
	{
		public override int LabelNumber{ get{ return 1023760; } } // A Rose In A Vase
		public override bool ForceShowProperties{ get{ return ObjectPropertyList.Enabled; } }


            [Constructable]
		public RoseInVase() : base(0xEB0)
		{
			Hue = 33;
                  LootType = LootType.Blessed;      
                  Weight = 1.0;
		}

		public RoseInVase(Serial serial) : base(serial)
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
	