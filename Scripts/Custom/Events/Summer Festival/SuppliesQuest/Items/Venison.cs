using System;

namespace Server.Items
{
    public class Venison: Item
    {
        [Constructable]
        public Venison()
            : base(0x1368)
        {
			this.Name = "Venison";
            this.LootType = LootType.Blessed;
            this.Weight = 350;
            this.Hue = 2317;
			QuestItem = true;
        }

        public Venison(Serial serial)
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