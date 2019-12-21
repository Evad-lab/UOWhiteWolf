namespace Server.Items
{
    public class RandomGarbageDeco : Item
    {
        private static readonly int[] m_Types = new int[] { 0x10F0, 0x10F3, 0x10EE, 0x10EF, 0x10F1, 0x10F2 };
        [Constructable]
        public RandomGarbageDeco()
            : this(m_Types[Utility.Random(m_Types.Length)])
        {
        }

        [Constructable]
        public RandomGarbageDeco(int itemid)
            : base(itemid)
        {
            this.Hue = 0x0;
        }

        public RandomGarbageDeco(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "garbage";
            }
        }
        public override double DefaultWeight
        {
            get
            {
                return 1.0;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}