using System;
using System.Reflection;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Commands
{
	public class Humiliate
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Humiliate", AccessLevel.Owner, new CommandEventHandler( Humiliate_OnCommand ) );
		}

		[Usage( "Humiliate" )]
		[Description( "The target will say things that they don't want to say." )]
		private static void Humiliate_OnCommand( CommandEventArgs e )
		{
			int amount = 1;
			if ( e.Length >= 1 )
				amount = e.GetInt32( 0 );

			e.Mobile.Target = new PunishTarget();
			e.Mobile.SendMessage( 1152, "Who do you wish to humiliate?" );
		}

		private class PunishTarget : Target
		{
			public PunishTarget() : base( 10, false, TargetFlags.None )
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
			private int count;
			public InternalTimer( Mobile mo, int c ) : base( TimeSpan.FromSeconds( Utility.Random( 5, 15 )))
			{
				m = mo;
				count = c;
			}
			protected override void OnTick()
			{
				if ( !m.Deleted && m != null && m.Alive && count < 100 )
				{
					int chance = Utility.Random( 1, 100 );
					if ( chance <= 5 )
						m.Say( "Look at me, I am such an asshat!" );
					else if ( chance <= 10 )
						m.Say( "Anyone want to sleep with my mother?" );
					else if ( chance <= 15 )
						m.Say( "Giving away free gold!" );
					else if ( chance <= 20 )
						m.Say( "Everyone here is a douchebag!" );
					else if ( chance <= 25 )
						m.Say( "I like it in the butt." );
					else if ( chance <= 30 )
						m.Say( "Sometimes I get naked and watch old Hannah Montana reruns :D" );
					else if ( chance <= 35 )
						m.Say( "Anyone want a blowjob?" );
					else if ( chance <= 40 )
						m.Say( "I masturbate to video games." );
					else if ( chance <= 45 )
						m.Say( "I get off watching animals have sex." );
					else if ( chance <= 50 )
						m.Say( "I live with my mother, and I am going to die a virgin." );
					else if ( chance <= 55 )
						m.Say( "Sometimes I seriously consider shaving my pubes into the shape of a big U.O." );
					else if ( chance <= 60 )
						m.Say( "I like rusty spoons." );
					else if ( chance <= 65 )
						m.Say( "My life is a lie and all of my children will be gay." );
					else if ( chance <= 70 )
						m.Say( "I once put my genitals into a jar of Peanut Butter." );
					else if ( chance <= 75 )
						m.Say( "I would SOOOO bang Martha Stewart if I had the chance." );
					else if ( chance <= 80 )
						m.Say( "I'm the prettiest girl at the Harvest Moon Ball!" );
					else if ( chance <= 85 )
						m.Say( "Does this armor make my ass look fat?" );
					else if ( chance <= 90 )
						m.Say( "I fantasize about auditioning for American Idol, singing 'Girls Just Wanna Have Fun'." );
					else if ( chance <= 95 )
						m.Say( "Who likes Donkey balls? I like donkey balls!" );
					else
						m.Say( "My mom goes to college." );
					new InternalTimer( m, count ).Start();
				}
			}
		}
	}
}
