using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class AncientIngotKey : Item
	{
		[Constructable]
		public AncientIngotKey() : this( null )
		{
		}

		[Constructable]
		public AncientIngotKey ( string name ) : base ( 0x1BE8 )
		{
			Name = "Ancient Ingot Key";
			LootType = LootType.Blessed;
			Hue = 1266;
		}

		public AncientIngotKey ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )
		{
			Item a = m.Backpack.FindItemByType( typeof(ShinyIronIngot) );
			if ( a != null )
			{	
				Item b = m.Backpack.FindItemByType( typeof(ShinyDullCopperIngot) );
				
				if ( b != null )
				{
					Item c = m.Backpack.FindItemByType( typeof(ShinyShadowIronIngot) );
					
					if ( c != null )
					{
						Item d = m.Backpack.FindItemByType( typeof(ShinyBronzeIngot) );
						
						if ( d != null )
						{
							Item e = m.Backpack.FindItemByType( typeof(ShinyGoldIngot) );
							
							if ( e != null )
							{
								Item f = m.Backpack.FindItemByType( typeof(ShinyAgapiteIngot) );
								
								if ( f != null )
								{
									Item g = m.Backpack.FindItemByType( typeof(ShinyVeriteIngot) );
									
									if ( g != null )
									{
										Item h = m.Backpack.FindItemByType( typeof(ShinyValoriteIngot) );
										
										if ( h != null )
										{
											Item i = m.Backpack.FindItemByType( typeof(ShinyBlazeIngot) );
											
											if ( i != null )
											{
												Item j = m.Backpack.FindItemByType( typeof(ShinyIceIngot) );
												
													if ( j != null )
													{
														Item k = m.Backpack.FindItemByType( typeof(ShinyElectrumIngot) );
														
														if ( k != null )
														{
															Item l = m.Backpack.FindItemByType( typeof(ShinyToxicIngot) );
															
															if ( l != null )
															{
																Item o = m.Backpack.FindItemByType( typeof(ShinyPlatinumIngot) );
																
																if ( o != null )
																{
																	Item n = m.Backpack.FindItemByType( typeof(ShinyCopperIngot) );
																	
																	if ( n != null )
																	{			
																		m.AddToBackpack( new RestoredIngotKey() );
																		
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
																		l.Delete();
																		o.Delete();
																		n.Delete();
																		
																		m.SendMessage( "You Combine the knowledge of all the specialty ores into a storage key" );
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