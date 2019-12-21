// Scripted by Karmageddon
using System;
using Server.Gumps;
using Server.Mobiles;

namespace Server.Items
{
	public class DragonGlobe : Item
	{
		[Constructable]
		public DragonGlobe() : base( 0xE2E )
		{
			Movable=false;
			Name="Dragon Summoning Globe";			
		}
	
		public DragonGlobe( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			Container pack = from.Backpack;
	
			if ( pack != null && pack.ConsumeTotal( typeof( DragonSummonScroll ), 1 ) )
			{
				Map map = from.Map;
				
				BaseCreature wyrm = new QuestWyrm();				

				Point3D loc = from.Location;
				bool validLocation = false;

				for ( int j = 0; !validLocation && j < 10; ++j )
				{
					int x = from.X + Utility.Random( 3 ) - 1;
					int y = from.Y + Utility.Random( 3 ) - 1;
					int z = map.GetAverageZ( x, y );

					if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
						loc = new Point3D( x, y, Z );
					else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
						loc = new Point3D( x, y, z );
				}

				wyrm.MoveToWorld( loc, map );

				wyrm.Combatant = from;
			}
			else
			{
				from.SendMessage(0x22,"You need a Scroll of Dragon Summoning to use that.");
			
			}

		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}