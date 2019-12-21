namespace Server.Items
{
    public class RandomBloodDeco : Item
    {
        private static readonly int[] m_Types = new int[] { 0x122A, 0x122B, 0x122C, 0x122D, 0x122F, 0x122E, };
        [Constructable]
        public RandomBloodDeco()
            : this(m_Types[Utility.Random(m_Types.Length)])
        {
        }

        [Constructable]
        public RandomBloodDeco(int itemid)
            : base(itemid)
        {
            this.Hue = 0x0;
        }

        public RandomBloodDeco(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "blood";
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