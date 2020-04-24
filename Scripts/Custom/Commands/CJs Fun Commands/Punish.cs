using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Commands
{
	public class Punish
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Punish", AccessLevel.Administrator, new CommandEventHandler( Punish_OnCommand ) );
		}

		[Usage( "Punish" )]
		[Description( "Curses an insolent person in an evil way." )]
		private static void Punish_OnCommand( CommandEventArgs e )
		{
			int amount = 1;
			if ( e.Length >= 1 )
				amount = e.GetInt32( 0 );

			e.Mobile.Target = new PunishTarget();
			e.Mobile.SendMessage( 1152, "Target the insolent prick you wish to punish." );
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
					m.SendMessage( 32, "You are cursed with the eternal presence of Martha Stuart." );
					MarthaStewart spawn = new MarthaStewart( m );
					spawn.MoveToWorld( m.Location, m.Map );
					spawn.Say( "Prepare to be punished, " +m.Name.ToString(), "!" );
				}
			}
		}
	}
}
