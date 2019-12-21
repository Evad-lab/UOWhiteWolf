//Scripted By James4245
using System;
using Server;

namespace Server.Items
{
    public class TheHeadOfSauron : Item                
        {
        
		[Constructable]
		public TheHeadOfSauron() : base( 0x1DA0 )
		{
			Weight = 1.0;
            Name = "TheHeadOfSauron";
			Hue = 853;
		}

        public TheHeadOfSauron(Serial serial) : base(serial)
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
		
					
		public override void OnDoubleClick( Mobile from ) 
		{ 
			switch ( Utility.Random( 4 ) )
			{
				default:
				case  0: from.SendMessage( "Stop Poking Me" ); break;
                case  1: from.SendMessage( "Return Me To My Body" ); break;
                case  2: from.SendMessage( "Help ME!!" ); break;
                case  3: from.SendMessage( "Man This Sucks" ); break;

			}
		}
	}	
}
