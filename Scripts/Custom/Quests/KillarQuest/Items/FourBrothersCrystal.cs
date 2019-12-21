using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class FourBrothersCrystal : Item
	{
		[Constructable]
		public FourBrothersCrystal() : this( null )
		{
		}

		[Constructable]
		public FourBrothersCrystal ( string name ) : base ( 0x1F1C )
		{
			Name = "Four Brothers Crystal";
			LootType = LootType.Blessed;
			Hue = 1161;
		}

		public FourBrothersCrystal ( Serial serial ) : base ( serial )
		{
		}

      		
		public override void OnDoubleClick( Mobile m )

		{
			Item d = m.Backpack.FindItemByType( typeof(RingOfKillar) );
			if ( d != null )
			{	
				Item c = m.Backpack.FindItemByType( typeof(BraceletOfKillar) );
				if ( c != null )
				{
					Item n = m.Backpack.FindItemByType( typeof(HatOfKillar) );
					if ( n != null )
					{
						Item p = m.Backpack.FindItemByType( typeof(GlovesOfKillar) );
						if ( p != null )
						{
							m.AddToBackpack( new SwordOfKillar() );
							d.Delete();
							c.Delete();
							n.Delete();
							p.Delete();
							m.SendMessage( "You Combine the Power Of The Killar Ancestors!!!" );
						}
					}
					else
					{
						m.SendMessage( "You Are Missing Something..." );
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