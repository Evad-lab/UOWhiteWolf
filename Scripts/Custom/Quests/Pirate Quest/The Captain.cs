using System;
using System.Collections;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server;
using Server.Items;
using Server.Gumps;
using System.Collections.Generic; 

namespace Server.Mobiles
{
    public class TheCaptain : Mobile
	    {		

		[Constructable]
		public TheCaptain()
		{
			Name = "The Captain";
			Body = 400;
			BaseSoundID = 0;
                        Hue = 33785;
                        CantWalk = true;
                        Blessed = true;	

			Direction = Direction.South;

			Boots bt = new Boots();
                        bt.Hue = 0;
                        AddItem( bt );

                        LongPants lp = new LongPants();
                        lp.Hue = 0;
                        AddItem( lp );

		        FancyShirt fs = new FancyShirt();
                        fs.Hue = 0;
                        AddItem( fs );

			TricorneHat th = new TricorneHat();
                        th.Hue = 0;
                        AddItem( th );			

	                Scimitar sc = new Scimitar();
                        AddItem( sc );

			GoldBeadNecklace gn = new GoldBeadNecklace();
			AddItem( gn );

			GoldBracelet gb = new GoldBracelet();
			AddItem( gb );

			GoldEarrings ge = new GoldEarrings();
			AddItem( ge );

			GoldRing gr = new GoldRing();
			AddItem( gr );			
                        
                        AddItem( new PonyTail(1149));
                     
			AddItem( new Vandyke(1149));						
		}
		
		public TheCaptain( Serial serial ) : base( serial )
		{
		}
            public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list );
                    list.Add(new PirateEntry(from, this)); 
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
		
		public class PirateEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public PirateEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( PirateGump ) ) )
					{
						mobile.SendGump( new PirateGump( mobile ));
						
					} 
				}
			}
		}
		
		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;

			if ( mobile != null)
			{
				if( dropped is CaptainsCutlass )
         		{
         			

					dropped.Delete();
 
				mobile.SendMessage( "Many thanks to ye for returning my cutlass!." );
				mobile.AddToBackpack( new PirateCutlass() );
					
					return true;

         		}
				
         		else
         		{
					SayTo( from, "That be not my cutlass." );
     			}
			}
			return false;

		
		}

	}
}