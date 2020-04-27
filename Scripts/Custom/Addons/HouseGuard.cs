using System;

namespace Server.Items
{
	public class HouseGuard : Item
	{
		[Constructable]
		public HouseGuard() : base( 0x151C )
		{
		      Weight = 0.0;
                  LootType = LootType.Blessed;

            }

		public HouseGuard( Serial serial ) : base( serial )
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
		      
                  if ( Weight == 4.0 )
				Weight = 1.0;

            }
	}
}