using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class OldSewingBasketKey : Item
	{
		[Constructable]
		public OldSewingBasketKey() : this( null )
		{
		}

		[Constructable]
		public OldSewingBasketKey ( string name ) : base ( 0xF9D )
		{
			Name = "Old Sewing Basket";
			LootType = LootType.Blessed;
			Hue = 1108;
		}

		public OldSewingBasketKey ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )
		{
			Item a = m.Backpack.FindItemByType( typeof(SpecialtyLeather) );
			if ( a != null )
			{	
				Item b = m.Backpack.FindItemByType( typeof(SpecialtySpinedLeather) );
				
				if ( b != null )
				{
					Item c = m.Backpack.FindItemByType( typeof(SpecialtyHornedLeather) );
					
					if ( c != null )
					{
						Item d = m.Backpack.FindItemByType( typeof(SpecialtyBarbedLeather) );
						
						if ( d != null )
						{
							Item e = m.Backpack.FindItemByType( typeof(SpecialtyPolarLeather) );
							
							if ( e != null )
							{
								Item f = m.Backpack.FindItemByType( typeof(SpecialtySyntheticLeather) );
								
								if ( f != null )
								{
									Item g = m.Backpack.FindItemByType( typeof(SpecialtyDaemonicLeather) );
									
									if ( g != null )
									{
										Item h = m.Backpack.FindItemByType( typeof(SpecialtyShadowLeather) );
										
										if ( h != null )
										{
											Item i = m.Backpack.FindItemByType( typeof(SpecialtyFrostLeather) );
											
											if ( i != null )
											{
												Item j = m.Backpack.FindItemByType( typeof(SpecialtyEtherealLeather) );
												
														if ( j != null )
														{	
																			
															m.AddToBackpack( new NewSewingBasketKey() );
																		
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
													
													m.SendMessage( "You Combine the knowledge of all the Leathers into a storage key" );
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