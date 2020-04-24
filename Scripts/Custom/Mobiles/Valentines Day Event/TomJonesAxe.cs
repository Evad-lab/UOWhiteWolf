using System;

namespace Server.Items
{
    public class TomJonesAxe : DoubleAxe
	{
		public override bool IsArtifact { get { return true; } }
        [Constructable]
        public TomJonesAxe()
        {
            Hue = 37;
            WeaponAttributes.HitEnergyArea = 50;
			WeaponAttributes.HitPoisonArea = 50;
			WeaponAttributes.HitLeechHits = 40;
			WeaponAttributes.HitLeechMana = 40;
            Attributes.WeaponDamage = 50;
			Attributes.WeaponSpeed = 35;
        }

        public TomJonesAxe(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1061106;
            }
        }// Axe of Tom Jones
        public override int ArtifactRarity
        {
            get
            {
                return 66;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 255;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 255;
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