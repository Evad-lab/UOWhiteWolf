using System;
using Server;
using Server.Items;
using Server.Targeting;
using Server.Targets;
using Server.Network;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Gumps
{
	public class LagGump : Gump
	{
		public LagGump() : base( Utility.Random( 0, 650 ), Utility.Random( 0, 1050 ) )
		{

			AddPage( 0 );

			AddBackground( 0, 0, Utility.Random( 100, 550 ), Utility.Random( 100, 550 ), 5054 );
			AddLabel( 5, 5, 32, "OMG LAG!" );
		}

		public override void OnResponse( Server.Network.NetState sender, RelayInfo info )
		{
		}
	}
}