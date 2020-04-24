using System;
using Server.Items;

namespace Server.Items
{
	public class ExRing : GoldRing
	{
		public override bool IsArtifact { get { return true; } }
		public override int LabelNumber{ get{ return 1080238; } } // The Ex's Ring
        public override SetItem SetID{ get{ return SetItem.Luck; } }
		public override int Pieces{ get{ return 2; } }

		[Constructable]
		public ExRing() : base()
		{
			this.Weight = 1.0;
            this.Hue = 1165;

            this.Attributes.Luck = 200;
            this.Attributes.CastSpeed = 1;
            this.Attributes.CastRecovery = 2;

            this.SetHue = 1165;
            this.SetAttributes.Luck = 200;
            this.SetAttributes.RegenHits = 2;
            this.SetAttributes.RegenMana = 2;
            this.SetAttributes.CastSpeed = 1;
            this.SetAttributes.CastRecovery = 2;
		}

		public ExRing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
