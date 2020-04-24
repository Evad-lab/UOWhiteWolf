using System;

namespace Server.Items
{
   [Flipable(0x1541, 0x1542)]
    public class StarterSash : BaseMiddleTorso
    {
        [Constructable]
        public StarterSash()
            : base(0x1541, 0x1542)
        {
            this.Weight = 1.0;
			this.Name = "One of the first settlers on UO White Wolf";
			this.Hue = 1153;
			this.LootType = LootType.Blessed;

        }
		
		        public override int BasePhysicalResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BaseFireResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BaseColdResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BasePoisonResistance
        {
            get
            {
                return 2;
            }
        }
        public override int BaseEnergyResistance
        {
            get
            {
                return 2;
            }
        }

        public StarterSash(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}