using System;
using System.Collections;
using System.Collections.Generic;
using Server.Commands;
using Server.Commands.Generic;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Engines.Quests;
using Server.Engines.Quests.TheGraveDigger;

namespace Server
{
	public class GenerateGDQ
	{
		public GenerateGDQ()
		{
		}

		public static void Initialize()
		{
			CommandSystem.Register( "GenGDQ", AccessLevel.Administrator, new CommandEventHandler( GenerateGDQ_OnCommand ) );
		}

		[Usage( "GenGDQ" )]
		[Description( "Generates Grave Digger Quest" )]
		public static void GenerateGDQ_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendMessage( "Please hold while the quest is being generated." );

			GenDecore.CreateDecore();
			GenMobiles.CreateMobiles();
			GenSpawners.CreateSpawners();

			e.Mobile.SendMessage( "Grave Digger Quest Generated." );
		}

		public class GenDecore
		{
			
			public GenDecore()
			{
			}

			private static Queue m_Queue = new Queue();

			public static bool FindDecore( Map map, Point3D p )
			{
				IPooledEnumerable eable = map.GetItemsInRange( p, 0 );

				foreach ( Item item in eable )
				{
					if ( item is Stool )
					{
						int delta = item.Z - p.Z;

						if ( delta >= -12 && delta <= 12 )
							m_Queue.Enqueue( item );
					}
				}

				eable.Free();

				while ( m_Queue.Count > 0 )
					((Item)m_Queue.Dequeue()).Delete();

				return false;
			}

			public static void CreateDecore( Point3D pointLocation, Map mapLocation )
			{
				Point3D stool = new Point3D( 1545, 1768, 10 );

				if ( !FindDecore( mapLocation, pointLocation ) )
				{
				
					if ( pointLocation == stool )
					{
						Stool sto = new Stool();
						sto.Movable = false;
						sto.MoveToWorld( pointLocation, mapLocation );
					}
				}
			}

			public static void CreateDecore( int xLoc, int yLoc, int zLoc, Map map )
			{
				CreateDecore( new Point3D( xLoc, yLoc, zLoc ), map);
			}

			public static void CreateDecoreFacet( Map map )
			{
				CreateDecore( 1545, 1768, 10, map );
			}


			public static void CreateDecore()
			{
				CreateDecoreFacet( Map.Trammel );
			}
		}

		public class GenMobiles
		{
			
			public GenMobiles()
			{
			}

			private static Queue m_Queue = new Queue();

			public static bool FindMobile( Map map, Point3D p )
			{
				IPooledEnumerable eable = map.GetMobilesInRange( p, 0 );

				foreach ( Mobile mob in eable )
				{
					if ( mob is BaseQuester )
					{
						int delta = mob.Z - p.Z;

						if ( delta >= -12 && delta <= 12 )
							m_Queue.Enqueue( mob );
					}
				}

				eable.Free();

				while ( m_Queue.Count > 0 )
					((Mobile)m_Queue.Dequeue()).Delete();

				return false;
			}

			public static void CreateMobiles( Point3D pointLocation, Map mapLocation )
			{
				Point3D theDrunk = new Point3D( 3736, 2220, 20 );
				Point3D vincent = new Point3D( 1545, 1768, 10 );
				Point3D linda = new Point3D( 2710, 2106, 0 );
				Point3D boyfriend = new Point3D( 2712, 2104, 0 );

				if ( !FindMobile( mapLocation, pointLocation ) )
				{
					TheDrunk td = new TheDrunk();
					Vincent v = new Vincent();
					Linda l = new Linda();
					LindasBoyfriend bf = new LindasBoyfriend();

					if ( pointLocation ==  theDrunk )
					{
						td.Direction = Direction.East;
						td.Location = pointLocation;
						td.Map = mapLocation;
						World.AddMobile( td );
					}

					if ( pointLocation ==  vincent )
					{
						v.Direction = Direction.North;
						v.Location = pointLocation;
						v.Map = mapLocation;
						World.AddMobile( v );
					}

					if ( pointLocation ==  boyfriend )
					{
						bf.Direction = Direction.South;
						bf.Location = pointLocation;
						bf.Map = mapLocation;
						World.AddMobile( bf );
					}

					if ( pointLocation ==  linda )
					{
						l.Direction = Direction.East;
						l.Location = pointLocation;
						l.Map = mapLocation;
						World.AddMobile( l );
					}

					l.BoyFriend = bf;
				}
			}

			public static void CreateMobiles( int xLoc, int yLoc, int zLoc, Map map )
			{
				CreateMobiles( new Point3D( xLoc, yLoc, zLoc ), map);
			}

			public static void CreateMobilesFacet( Map map )
			{
				CreateMobiles( 3736, 2220, 20, map );
				CreateMobiles( 1545, 1768, 10, map );
				CreateMobiles( 2710, 2106, 0, map );
				CreateMobiles( 2712, 2104, 0, map );
			}

			public static void CreateMobiles()
			{
				CreateMobilesFacet( Map.Trammel );
			}
		}

		public class GenSpawners
		{

			//configuration
			private const bool TotalRespawn = true;//Should we spawn them up right away?
			private static TimeSpan MinTime = TimeSpan.FromMinutes( 3 );//min spawn time
			private static TimeSpan MaxTime = TimeSpan.FromMinutes( 5 );//max spawn time

			public GenSpawners()
			{
			}

			private static Queue m_ToDelete = new Queue();

			public static void ClearSpawners( int x, int y, int z, Map map )
			{
				IPooledEnumerable eable = map.GetItemsInRange( new Point3D( x, y, z ), 0 );

				foreach ( Item item in eable )
				{
					if ( item is Spawner && item.Z == z )
						m_ToDelete.Enqueue( item );
				}

				eable.Free();

				while ( m_ToDelete.Count > 0 )
					((Item)m_ToDelete.Dequeue()).Delete();
			}

			public static void CreateSpawners()
			{
				//Rares
				PlaceSpawns( 1994, 3203, 0, "BloodLich" );
				PlaceSpawns( 1185, 3608, 0, "YeastFarmer" );
				PlaceSpawns( 742, 1152, 0, "LordYoshimitsu" );
				PlaceSpawns( 3355, 293, 4, "Bacchus" );
			}

			public static void PlaceSpawns( int x, int y, int z, string types )
			{

				switch ( types )
				{
					case "BloodLich":
						MakeSpawner( "BloodLich", x, y, z, Map.Trammel, true );
						MinTime = TimeSpan.FromMinutes( 3 );
						MaxTime = TimeSpan.FromMinutes( 5 );
						break;
					case "YeastFarmer":
						MakeSpawner( "YeastFarmer", x, y, z, Map.Trammel, true );
						MinTime = TimeSpan.FromMinutes( 3 );
						MaxTime = TimeSpan.FromMinutes( 5 );
						break;
					case "LordYoshimitsu":
						MakeSpawner( "LordYoshimitsu", x, y, z, Map.Trammel, true );
						MinTime = TimeSpan.FromMinutes( 3 );
						MaxTime = TimeSpan.FromMinutes( 5 );
						break;
					case "Bacchus":
						MakeSpawner( "Bacchus", x, y, z, Map.Trammel, true );
						MinTime = TimeSpan.FromMinutes( 3 );
						MaxTime = TimeSpan.FromMinutes( 5 );
						break;
					default:
						break;
				}
			}

			private static void MakeSpawner( string types, int x, int y, int z, Map map, bool start )
			{
				ClearSpawners( x, y, z, map );

				Spawner sp = new Spawner( types );

				sp.MaxCount = 1;

				sp.Running = true;
				sp.HomeRange = 15;
				sp.MinDelay = MinTime;
				sp.MaxDelay = MaxTime;

				sp.MoveToWorld( new Point3D( x, y, z ), map );

			}
		}
	}
}
