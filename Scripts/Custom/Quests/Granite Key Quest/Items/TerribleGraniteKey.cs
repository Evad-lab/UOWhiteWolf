using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class TerribleGraniteKey : Item
	{
		[Constructable]
		public TerribleGraniteKey() : this( null )
		{
		}

		[Constructable]
		public TerribleGraniteKey ( string name ) : base ( 0x177C  )
		{
			Name = "Terrible Granite Key";
			LootType = LootType.Blessed;
			Hue = 1108;
		}

		public TerribleGraniteKey ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )
		{
			Item a = m.Backpack.FindItemByType( typeof(MissingBlazeGranite) );
			if ( a != null )
			{	
				Item b = m.Backpack.FindItemByType( typeof(MissingIceGranite) );
				
				if ( b != null )
				{
					Item c = m.Backpack.FindItemByType( typeof(MissingToxicGranite) );
					
					if ( c != null )
					{
						Item d = m.Backpack.FindItemByType( typeof(MissingElectrumGranite) );
						
						if ( d != null )
						{
							Item e = m.Backpack.FindItemByType( typeof(MissingPlatinumGranite) );
							
							if ( e != null )
							{
									
								m.AddToBackpack( new ImprovedGraniteKey() );
																		
										a.Delete();
										b.Delete();
										c.Delete();
										d.Delete();
										e.Delete();
																											
								m.SendMessage( "You Combine the knowledge of all the Missing Granite specimens into a storage key" );
								Delete();
							}
							else
								m.SendMessage( "You are missing something..." );
		
							}
						}
					}
				}
			}
	

		public override void Serialize ( GenericWriter writer)
		{
			base.Serialize ( writer );

			writer.Write ( (int) 0);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize ( reader );

			int version = reader.ReadInt();
		}
	}
}		