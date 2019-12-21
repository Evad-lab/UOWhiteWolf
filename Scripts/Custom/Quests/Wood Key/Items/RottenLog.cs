using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class RottenLog : Item
	{
		[Constructable]
		public RottenLog() : this( null )
		{
		}

		[Constructable]
		public RottenLog ( string name ) : base ( 0x1BDD )
		{
			Name = "Rotten Log";
			LootType = LootType.Blessed;
			Hue = 1457;
		}

		public RottenLog ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )

		{
			Item a = m.Backpack.FindItemByType( typeof(FreshEbonyLog) );
			if ( a != null )
			{	
				Item b = m.Backpack.FindItemByType( typeof(FreshRedwoodLog) );
				
				if ( b != null )
				{
					Item c = m.Backpack.FindItemByType( typeof(FreshBambooLog) );
					
					if ( c != null )
					{
						Item d = m.Backpack.FindItemByType( typeof(FreshPurpleHeartLog) );
						{
							if ( d != null )
							{
							 Item e = m.Backpack.FindItemByType( typeof(FreshPetrifiedLog) );
							 {
								 if (e !=null)
								 {
			
				        m.AddToBackpack( new NewWood() );
						a.Delete();
						b.Delete();
						c.Delete();
						d.Delete();
						e.Delete();
						m.SendMessage( "You Combine the components of the Fresh Logs into a New Wood" );
						this.Delete();
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
