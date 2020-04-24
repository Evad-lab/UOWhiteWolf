using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Commands
{
	public class Slaughter
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Slaughter", AccessLevel.Administrator, new CommandEventHandler( Slaughter_OnCommand ) );
		}

		[Usage( "Slaughter" )]
		[Description( "Repeatedly kills then ressurects someone." )]
		private static void Slaughter_OnCommand( CommandEventArgs e )
		{
			int amount = 1;
			if ( e.Length >= 1 )
				amount = e.GetInt32( 0 );

			e.Mobile.Target = new PunishTarget();
			e.Mobile.SendMessage( 1152, "Who do you wish to slaughter?" );
		}

		private class PunishTarget : Target
		{
			public PunishTarget() : base( 8, false, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object targ )
			{
				if ( targ is PlayerMobile )
				{
					PlayerMobile m = targ as PlayerMobile;
					new InternalTimer( m, 0 ).Start();
				}
			}
		}

		private class InternalTimer : Timer
		{
			private Mobile m;
			int count;
			public InternalTimer( Mobile mo, int c ) : base( TimeSpan.FromSeconds( 1.0 ))
			{
				m = mo;
				count = c;
			}
			protected override void OnTick()
			{
				if ( !m.Deleted && m != null && m.Alive && count < 60 )
				{
				    m.Blessed = false;
					m.Kill();
					m.Resurrect();
					m.Corpse.Delete();
					count += 1;
					new InternalTimer( m, count ).Start();
				}
			}
		}
	}
}
