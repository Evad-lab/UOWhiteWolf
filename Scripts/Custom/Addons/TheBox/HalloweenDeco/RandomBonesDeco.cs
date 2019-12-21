namespace Server.Items
{
    public class RandomBonesDeco : Item
    {
        private static readonly int[] m_Types = new int[] { 0xECA, 0xECF, 0xED0, 0xECD, 0xECE, 0x1AE1, 0x1AE2, 0x1AE3, 0x1B16, 0x1B1B, 0x1B09, 0x1B0B, 0x1B10, 0x1B0D, 0x1B13, 0x1B1A, 0x1B1C, 0x1B17, 0x1B18, 0x1B12 };
        [Constructable]
        public RandomBonesDeco()
            : this(m_Types[Utility.Random(m_Types.Length)])
        {
        }

        [Constructable]
        public RandomBonesDeco(int itemid)
            : base(itemid)
        {
            this.Hue = 0x0;
        }

        public RandomBonesDeco(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "bones";
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