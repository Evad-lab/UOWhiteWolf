using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Network;
using Server.Spells;
using Server.Targeting;
using Server.Targets;
using Server.Misc;
using System.IO;
using System.Collections;

using Server.Commands;
using Server.Gumps;

namespace Server.Scripts.Commands
{
	public class ExplodeCommand
	{
		public static void Initialize()
		{
			CommandSystem.Register( "Explode", AccessLevel.GameMaster, new CommandEventHandler( Explode_OnCommand ) );
		}

		private class ExplodeTarget : Target
		{
			public ExplodeTarget() : base( -1, false, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object o )
			{
				PlayerMobile pm = from as PlayerMobile;
				Mobile target = o as Mobile;

				Map map = pm.Map;
				if ( map == null || map == Map.Internal )
					return;

				if ( target != null && target is Mobile && target == pm )
				{
					pm.SendMessage("Why the hell would you wanna blow yourself up?!");
					return;
				}					

				if ( target != null && target is Mobile && target.Alive )
				{		
					Point3D ourLoc = target.Location;
					Point3D startLoc = new Point3D( ourLoc.X, ourLoc.Y, ourLoc.Z );

					target.FixedParticles( 0x36BD, 20, 10, 5044, EffectLayer.Waist );
					target.PlaySound( 0x307 );

					DoLaunchLimbs( target, pm, ourLoc, startLoc, map );
				}
				else
				{
					pm.SendMessage("You can only Explode Mobiles, and they have to be Alive...");
					return;
				}
			}

			private static void DoLaunchLimbs( Mobile killed, PlayerMobile from, Point3D OurLoc, Point3D StartLoc, Map map )
			{
				if( killed.Player && (killed.BodyValue == 0x190 || killed.BodyValue == 0x191) )
				{
					if (killed.Mounted == true)
					{
						IMount mount = killed.Mount;

						if ( mount != null )
							mount.Rider = null;
					}
				
					Backpack bag = new Backpack();
					Container pack = killed.Backpack;
					BankBox box = killed.BankBox;
					ArrayList equipitems = new ArrayList(killed.Items);
					ArrayList bagitems = new ArrayList( pack.Items );
					foreach (Item item in equipitems)
								
					{
						if ((item.Layer != Layer.Bank) && (item.Layer != Layer.Backpack) && (item.Layer != Layer.Hair) && (item.Layer != Layer.FacialHair))
						{
							pack.DropItem( item );
		
						}
					}
					Container pouch = killed.Backpack;
					ArrayList finalitems = new ArrayList( pouch.Items );
					foreach (Item items in finalitems)
					{
						bag.DropItem(items);
					}
					box.DropItem(bag);

					killed.Kill();

					int effecthue = killed.Hue;
					if ( effecthue >= 30000 )
						effecthue = 0;

					//BEGIN HEAD//
					Point3D endHeadLoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endHeadLoc, map ),
						0x1CE1, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishHeadLaunch ), new object[]{ from, endHeadLoc, map, killed } );
					//END HEAD//

					//BEGIN TORSO//
					Point3D endTorsoLoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endTorsoLoc, map ),
						0x1DAD, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishTorsoLaunch ), new object[]{ from, endTorsoLoc, map, killed } );
					//END TORSO//
		
					//LEFT LEG//
					Point3D endLLLoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endLLLoc, map ),
						0x1DB2, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishLLLaunch ), new object[]{ from, endLLLoc, map, killed } );
					//END LEFT LEG//

					//RIGHT LEG//
					Point3D endRLLoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endRLLoc, map ),
						0x1DA4, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishRLLaunch ), new object[]{ from, endRLLoc, map, killed } );
					//END RIGHT LEG//

					//LEFT ARM//
					Point3D endLALoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endLALoc, map ),
						0x1DA1, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishLALaunch ), new object[]{ from, endLALoc, map, killed } );
					//END LEFT ARM//

					//RIGHT ARM//
					Point3D endRALoc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endRALoc, map ),
						0x1DAF, 5, effecthue, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishRALaunch ), new object[]{ from, endRALoc, map, killed } );
					//END RIGHT ARM//

					//BLOOD//
					Point3D endBlood1Loc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endBlood1Loc, map ),
						0x122B, 5, 0, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishBlood1Launch ), new object[]{ from, endBlood1Loc, map, killed } );
					
					Point3D endBlood2Loc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endBlood2Loc, map ),
						0x122B, 5, 0, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishBlood2Launch ), new object[]{ from, endBlood2Loc, map, killed } );
					
					Point3D endBlood3Loc = new Point3D( StartLoc.X + Utility.RandomMinMax( -6, 6 ), StartLoc.Y + Utility.RandomMinMax( -6, 6 ), StartLoc.Z );
					Effects.SendMovingEffect( new Entity( Serial.Zero, StartLoc, map ), new Entity( Serial.Zero, endBlood3Loc, map ),
						0x122B, 5, 0, false, false );
					Timer.DelayCall( TimeSpan.FromSeconds( 0.5 ), new TimerStateCallback( FinishBlood3Launch ), new object[]{ from, endBlood3Loc, map, killed } );
					//END BLOOD//
				}
				else
				{
					killed.Kill();
				}
				if ( killed.Corpse != null )
				killed.Corpse.Delete();
			}

			private static void FinishHeadLaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endHeadLoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endHeadLoc, map, 458 );
			
				String headname = "Head of " + "" + killed.Name;
				CHead head = new CHead();
				head.Movable = true;
				head.Hue = hue;
				head.Name = headname;
				head.MoveToWorld( endHeadLoc, map );
			}

			private static void FinishTorsoLaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endTorsoLoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endTorsoLoc, map, 458 );
			
				CTorso torso = new CTorso();
				torso.Movable = true;
				torso.Hue = hue;
				torso.MoveToWorld( endTorsoLoc, map );
			
				CFire fire = new CFire();
				fire.Movable = true;
				fire.MoveToWorld( endTorsoLoc, map );
			}

			private static void FinishLLLaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endLLLoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endLLLoc, map, 458 );
			
				CLeftLeg leftleg = new CLeftLeg();
				leftleg.Movable = true;
				leftleg.Hue = hue;
				leftleg.MoveToWorld( endLLLoc, map );
			}

			private static void FinishRLLaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endRLLoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endRLLoc, map, 458 );
			
				CRightLeg rightleg = new CRightLeg();
				rightleg.Movable = true;
				rightleg.Hue = hue;
				rightleg.MoveToWorld( endRLLoc, map );
			}

			private static void FinishLALaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endLALoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endLALoc, map, 458 );
			
				CLeftArm leftarm = new CLeftArm();
				leftarm.Movable = true;
				leftarm.Hue = hue;
				leftarm.MoveToWorld( endLALoc, map );
			}

			private static void FinishRALaunch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endRALoc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				int hue = killed.Hue;
				if ( hue >= 30000 )
					hue = 0;

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endRALoc, map, 458 );
			
				CRightArm rightarm = new CRightArm();
				rightarm.Movable = true;
				rightarm.Hue = hue;
				rightarm.MoveToWorld( endRALoc, map );
				
				CFire fire = new CFire();
				fire.Movable = true;
				fire.MoveToWorld( endRALoc, map );
			}

			private static void FinishBlood1Launch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endBlood1Loc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endBlood1Loc, map, 458 );
			
				Item blood = new Blood( 0x122A );
				blood.Movable = false;
				blood.MoveToWorld( endBlood1Loc, map );
			}

			private static void FinishBlood2Launch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endBlood2Loc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endBlood2Loc, map, 458 );
			
				Item blood = new Blood( 0x122F );
				blood.Movable = false;
				blood.MoveToWorld( endBlood2Loc, map );
			}

			private static void FinishBlood3Launch( object state )
			{
				object[] states = (object[])state;

				Mobile from = (Mobile)states[0];
				Point3D endBlood3Loc = (Point3D)states[1];
				Map map = (Map)states[2];
				Mobile killed = (Mobile)states[3];

				if ( map == null || map == Map.Internal )
					return;

				Effects.PlaySound( endBlood3Loc, map, 458 );
			
				Item blood = new Blood( 0x122D );
				blood.Movable = false;
				blood.MoveToWorld( endBlood3Loc, map );
			}

		}

		[Usage( "Explode" )]
		[Description( "Funnier than .kill" )]
		private static void Explode_OnCommand( CommandEventArgs e )
		{
			e.Mobile.Target = new ExplodeTarget();
			e.Mobile.SendMessage( "Explode Which Mobile?" );
		}
	}
}


