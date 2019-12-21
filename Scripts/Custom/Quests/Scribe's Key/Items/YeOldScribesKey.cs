using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class YeOldScribesKey : Item
	{
		[Constructable]
		public YeOldScribesKey() : this( null )
		{
		}

		[Constructable]
		public YeOldScribesKey ( string name ) : base ( 0xFEF )
		{
			Name = "Ye Olde Scribe's Key";
			LootType = LootType.Blessed;
		}

		public YeOldScribesKey ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )
		{
			Item a = m.Backpack.FindItemByType( typeof(WellUsedScribesPen) );
			if ( a != null )
			{	
				Item b = m.Backpack.FindItemByType( typeof(WonderousRune) );
				
				if ( b != null )
				{
					Item c = m.Backpack.FindItemByType( typeof(AlmostNotDeadScroll) );
					
					if ( c != null )
					{
						Item d = m.Backpack.FindItemByType( typeof(MinorExplosionScroll) );
						
						if ( d != null )
						{
							Item e = m.Backpack.FindItemByType( typeof(MinorLightningScroll) );
							
							if ( e != null )
							{
								Item f = m.Backpack.FindItemByType( typeof(MinorSiteScroll) );
								
								if ( f != null )
								{
									Item g = m.Backpack.FindItemByType( typeof(MinorStrengthScroll) );
									
									if ( g != null )
									{
										Item h = m.Backpack.FindItemByType( typeof(SmallerBladeSpiritsScroll) );
										
										if ( h != null )
										{
											Item i = m.Backpack.FindItemByType( typeof(SmallMeteorSwarmScroll) );
											
											if ( i != null )
											{
												Item j = m.Backpack.FindItemByType( typeof(UnlimitedScroll) );
												
													if ( j != null )
													{	
												Item k = m.Backpack.FindItemByType( typeof(MinorFireballScroll) );
												
													if ( k != null )
													{												
												
															m.AddToBackpack( new TheNewScribesKey() );
																		
															a.Delete();
															b.Delete();
															c.Delete();
															d.Delete();
															e.Delete();
															f.Delete();
															g.Delete();
															h.Delete();
															i.Delete();
															j.Delete();
															k.Delete();
																		
												m.SendMessage( "You Combine the ingredients into The New Scribe's Key" );
												Delete();
											}
											else
												m.SendMessage( "You are missing something..." );
											}
										}
									}
								}
							}
						}
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