/* Created by Hammerhand*/

using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class CrystalineFire : Item, ICommodity
	{
        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }
        [Constructable]
        public CrystalineFire()
            : this(1)
        {
        }
		[Constructable]
		public CrystalineFire(int amount) : base( 7961 )
		{
            Stackable = true;
            Name = "Crystaline Fire";
            Hue = 1260;
			Weight = 1.0;
            Amount = amount;
		}

        public CrystalineFire(Serial serial)
            : base(serial)
        {
        }
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}