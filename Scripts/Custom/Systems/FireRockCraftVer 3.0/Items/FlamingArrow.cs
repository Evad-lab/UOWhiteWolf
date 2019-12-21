/* Created by Hammerhand */

using System;

namespace Server.Items
{
	public class FlamingArrow : Item, ICommodity
	{
	/*	string ICommodity.Description
		{
			get
			{
				return String.Format( Amount == 1 ? "{0} FlamingArrow" : "{0} FlamingArrows", Amount );
			}
		}
        int ICommodity.DescriptionNumber { get { return LabelNumber; 
        }
        } */
        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public FlamingArrow() : this( 1 )
		{
		}

		[Constructable]
		public FlamingArrow( int amount ) : base( 0xF3F )
		{
            Name = "FlamingArrow";
            Hue = 1359;
			Stackable = true;
			Amount = amount;

		}


        public FlamingArrow(Serial serial)
            : base(serial)
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