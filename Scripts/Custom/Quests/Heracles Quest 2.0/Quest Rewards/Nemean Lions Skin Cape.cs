using System; 
using Server.Network; 
using Server.Targeting; 
using Server.Items; 

namespace Server.Items 
	{ 
	[Flipable( 0x230A, 0x2309 )]
	public class NemeanSkin : BaseCloak

	{

     	 public override int PhysicalResistance{ get{ return 10; } } 
      	 public override int FireResistance{ get{ return 15; } } 
     	 public override int EnergyResistance{ get{ return 12; } } 

		[Constructable]
		public NemeanSkin() : base( 0x230A )
		{
			Weight = 4.0;
			Hue= 0x497;
		}

		public NemeanSkin( Serial serial ) : base( serial )
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