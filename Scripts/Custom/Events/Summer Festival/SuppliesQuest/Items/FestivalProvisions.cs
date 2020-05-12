using System;

namespace Server.Items
{
    public class FestivalProvisions: Item
    {
        [Constructable]
        public FestivalProvisions()
            : base(2451)
		
        {
			this.Name = "Festival Provisions";
            this.LootType = LootType.Blessed;
            this.Weight = 350;
            this.Hue = 0;
			QuestItem = true;
        }

        public FestivalProvisions(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}