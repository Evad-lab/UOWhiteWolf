using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Commands
{
	public class Bounce
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Bounce", AccessLevel.Administrator, new CommandEventHandler( Bounce_OnCommand ) );
		}

		[Usage( "Bouce" )]
		[Description( "Makes someone return to the same spot they were when you targeted them every 15 seconds." )]
		private static void Bounce_OnCommand( CommandEventArgs e )
		{
			int amount = 1;
			if ( e.Length >= 1 )
				amount = e.GetInt32( 0 );

			e.Mobile.Target = new PunishTarget();
			e.Mobile.SendMessage( 1152, "Who do you wish to piss off?" );
		}

		private class PunishTarget : Target
		{
			public PunishTarget() : base( 7, false, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object targ )
			{
				if ( targ is PlayerMobile )
				{
					PlayerMobile m = targ as PlayerMobile;
					new InternalTimer( m, m.Location, m.Map, 0 ).Start();
				}
			}
		}

		private class InternalTimer : Timer
		{
			private Point3D returnloc;
			private Mobile m;
			private Map map;
			int count;
			public InternalTimer( Mobile mo, Point3D ret, Map ma, int i ) : base( TimeSpan.FromSeconds( 7.0 ))
			{
				returnloc = ret;
				m = mo;
				map = ma;
				count = i;
			}
			protected override void OnTick()
			{
				if ( !m.Deleted && m != null && m.Alive && count < 30 )
				{
					m.MoveToWorld( returnloc, map );
					count += 1;
					new InternalTimer( m, returnloc, map, count ).Start();
				}
			}
		}
	}
}
