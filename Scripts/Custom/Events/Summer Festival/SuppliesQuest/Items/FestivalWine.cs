using System;

namespace Server.Items
{
    public class FestivalWine: Item
    {
        [Constructable]
        public FestivalWine()
            : base(4014)
		
        {
			this.Name = "Festival Wine";
            this.LootType = LootType.Blessed;
            this.Weight = 350;
            this.Hue = 0;
			QuestItem = true;
        }

        public FestivalWine(Serial serial)
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