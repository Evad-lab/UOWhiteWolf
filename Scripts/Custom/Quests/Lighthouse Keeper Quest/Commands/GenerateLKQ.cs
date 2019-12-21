using System;
using System.Collections;
using Server;
using Server.Commands;
using Server.Mobiles;
using Server.Items;

namespace Server
{
	public class GenerateLKQ
	{
		public GenerateLKQ()
		{
		}

		public static void Initialize()
		{
			CommandSystem.Register( "GenLKQ", AccessLevel.Administrator, new CommandEventHandler( GenerateLKQ_OnCommand ) );
		}

		[Usage( "GenLKQ" )]
		[Description( "Generates Lighthouse Keeper Quest" )]
		public static void GenerateLKQ_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendMessage( "Generating Lighthouse Keeper Quest..." );

			GenSpawners.CreateSpawners();

			e.Mobile.SendMessage( "Quest Generation Complete!" );
		}

		public class GenSpawners
		{

			private const bool TotalRespawn = true;
			private static TimeSpan MinTime = TimeSpan.FromMinutes( 3 );
			private static TimeSpan MaxTime = TimeSpan.FromMinutes( 5 );

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
				PlaceSpawns( 3462, 3052, 7, "LighthouseKeeper" );
				PlaceSpawns( 3544, 2720, 2, "CrystalGolem" );
			}

			public static void PlaceSpawns( int x, int y, int z, string types )
			{

				switch ( types )
				{
					case "LighthouseKeeper":
						MakeSpawner( "LighthouseKeeper", x, y, z, Map.Trammel, true );
						MinTime = TimeSpan.FromMinutes( 3 );
						MaxTime = TimeSpan.FromMinutes( 5 );
						break;
					case "CrystalGolem":
						MakeSpawner( "CrystalGolem", x, y, z, Map.Trammel, true );
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
				sp.HomeRange = 1;
				sp.MinDelay = MinTime;
				sp.MaxDelay = MaxTime;

				sp.MoveToWorld( new Point3D( x, y, z ), map );

			}
		}
	}
}
