using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a training vorpal bunny corpse")]
    public class TrainingVorpalBunny : VorpalBunny
    {
        [Constructable]
        public TrainingVorpalBunny()
            : base()
        {
            this.Name = "a training vorpal bunny";
        }

        public TrainingVorpalBunny(Serial serial)
            : base(serial)
        {
        }

        public override void GenerateLoot()
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

            DelayBeginTunnel();
        }
    }
}