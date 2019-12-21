/* Created by Hammerhand*/

using System;
using Server.Items;
using Server.Network;
using Server.Targeting;
using Server.Engines.Craft;

namespace Server.Items
{
    public class SmallFireRock : Item, ICommodity
    {
        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }
        [Constructable]
        public SmallFireRock()
            : this(1)
        {
        }

        [Constructable]
        public SmallFireRock(int amount)
            : base(0x1366)
        {
            Stackable = true;
            Weight = 1;
            Hue = 1359;
            Name = "SmallFireRock";
            Amount = amount;
        }
        public SmallFireRock(Serial serial)
            : base(serial)
        {
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
    public class LargeFireRock : Item, ICommodity
    {
        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }
        [Constructable]
        public LargeFireRock()
            : this(1)
        {
        }

        [Constructable]
        public LargeFireRock(int amount)
            : base(0x1363)
        {
            Stackable = true;
            Weight = 3;
            Hue = 1359;
            Name = "LargeFireRock";
            Amount = amount;
        }
        public LargeFireRock(Serial serial)
            : base(serial)
        {
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