using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Commands
{
	public class Lag
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Lag", AccessLevel.Administrator, new CommandEventHandler( Lag_OnCommand ) );
		}

		[Usage( "Lag" )]
		[Description( "Simulates lag on a person who has it coming." )]
		private static void Lag_OnCommand( CommandEventArgs e )
		{
			int amount = 1;
			if ( e.Length >= 1 )
				amount = e.GetInt32( 0 );

			e.Mobile.Target = new PunishTarget();
			e.Mobile.SendMessage( 1152, "Who deserves this evil curse?" );
		}

		private class PunishTarget : Target
		{
			public PunishTarget() : base( 30, false, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object targ )
			{
				if ( targ is PlayerMobile )
				{
					PlayerMobile m = targ as PlayerMobile;
					for( int count = 0; count < 500; count ++ )
						m.SendGump( new LagGump() );
					m.SendMessage( 32, "Have fun dealing with this >:-)" );
				}
			}
		}
	}
}
