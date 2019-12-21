using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "a corpse of a scribe" )]
	public class OcolloScribe : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public OcolloScribe()
		{
			Name = "Jerry";
                        Title = "the Scribe Guy [?]";
			Body = 0x190;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();

			Utility.AssignRandomHair( this );

			AddItem( new Server.Items.Robe( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.LongPants( Utility.RandomNeutralHue() ) );
			AddItem( new Server.Items.Boots( Utility.RandomNeutralHue() ) );
			AddItem(new Server.Items.HalfApron( Utility.RandomNeutralHue() ) );

			Container pack = new Backpack();
			pack.DropItem( new Gold( 250, 300 ) );
			pack.Movable = false;
			AddItem( pack );

		}

		public OcolloScribe( Serial serial ) 
		        : base( serial )
		{
		}
		
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new OcolloScribeEntry( from, this ) ); 
	        } 

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public class OcolloScribeEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public OcolloScribeEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}

			public override void OnClick()
			{
				

                          if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;

				{
					if ( ! mobile.HasGump( typeof( OcolloScribeGump ) ) )
					{
						mobile.SendGump( new OcolloScribeGump( mobile ));
						mobile.AddToBackpack( new SmallerBladeSpiritsScroll() );
					} 
				}
			}
		}
	}
}
