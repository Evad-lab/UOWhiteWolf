using System;
using System.Collections;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server;
using Server.Items;
using Server.Gumps;

namespace Server.Mobiles
{
     	public class MMQMycologist : BaseGuildmaster
	    {
		public override NpcGuild NpcGuild{ get{ return NpcGuild.TailorsGuild; } }

		public override bool ClickTitle{ get{ return false; } }

		[Constructable]
		public MMQMycologist() : base( "Study of Fungus" )
		{
			Name = "The Legendary Mycologist";
			Female = false;			
		}

		public override VendorShoeType ShoeType
		{
			get{ return VendorShoeType.Boots; }
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			Item item = ( Utility.RandomBool() ? null : new Server.Items.FancyShirt( Utility.RandomRedHue() ) );

			if ( item != null && !EquipItem( item ) )
			{
				item.Delete();
				item = null;
			}

			if ( item == null )
				AddItem( new Server.Items.LongPants( Utility.RandomBlueHue() ) );

			AddItem( new Server.Items.FullApron( Utility.RandomGreenHue() ) );
			AddItem( new Server.Items.LongHair( Utility.RandomHairHue () ) );
			AddItem( new Server.Items.Bandana() );
		}

		
		public MMQMycologist( Serial serial ) : base( serial )
		{
		}
		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new MMQMycologistEntry( from, this ) ); 
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
		
		public class MMQMycologistEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public MMQMycologistEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( MMQMycologistGump ) ) )
					{
						mobile.SendGump( new MMQMycologistGump( mobile ));
						
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
				if( dropped is MMQSpores )
         		{
         			

					dropped.Delete();
 
				mobile.SendMessage( "Thank you for bringing Magical Mushroom Spores. I hope you find your reward useful." );
				mobile.AddToBackpack( new MagicMushroom() );
					
					return true;

         		}
				
         		else
         		{
					SayTo( from, "I have no need for that. I only need Magical Mushroom Spores to continue my research" );
     			}
			}
			return false;

		
		}

	}
}