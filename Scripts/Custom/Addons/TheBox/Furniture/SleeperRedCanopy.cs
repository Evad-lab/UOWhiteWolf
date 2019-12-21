// Script Package: Sleepable Beds
// Version: 1.0
// Author: Oak
// Servers: RunUO 2.0
// Date: 7/7/2006
// History: 
//  Written for RunUO 1.0 shard, Sylvan Dreams,  in February 2005. Based largely on work by David on his Sleepable NPCs scripts.
//  Modified for RunUO 2.0, removed shard specific customizations (wing layers, etc.)
//  Deedable code by Zardoz. 7/8/2006

using System;
using System.Collections;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Gumps;
using Server.Multis;

namespace Server.Items
{
	// version 1.1.1 Bed coordinates of 0,0,0 will cause npc to sleep and wake at it's current location.
	// version 1.0 initial release.
	public class SleeperRedCanopyAddon: BaseAddon, IChopable
	{

      public override BaseAddonDeed Deed
        {
            get
            {
                return new SleeperRedCanopyAddonDeed ();
            }
        }

		public SleeperRedCanopyAddon( Serial serial ) : base( serial )
		{
		}

		[Constructable]
		public SleeperRedCanopyAddon( ) 
		{
			Visible = true;
			Name = "Canopy Sleeper";
			AddComponent( new SleeperRedCanopyPiece(this, 2682), -1, 1, 0 );
			Hue = 37;
			AddComponent( new SleeperRedCanopyPiece(this, 2683), -1, 0, 0 );
			Hue = 37;
			AddComponent( new SleeperRedCanopyPiece(this, 2681), 0, 0, 0 );
			Hue = 37;
			AddComponent( new SleeperRedCanopyPiece(this, 2680), 0, 1, 0 );
			Hue = 37;
						AddonComponent ac;
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, -1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 0, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, -2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, -1, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, -1, -2, 17 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 10011 );
			AddComponent( ac, -2, 1, 0 );
			//ac = new AddComponent ( new SleeperRedCanopyPiece( 2682 ) );
			//ac.Hue = 37;
			//AddComponent( ac, -1, 1, 0 );
			//ac = AddComponent ( new SleeperRedCanopyPiece( 2683 ) );
			//ac.Hue = 37;
			//AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7807 );
			ac.Hue = 1150;
			ac.Name = "nightstand";
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2842 );
			ac.Light = LightType.Circle225;
			ac.Name = "lamp";
			AddComponent( ac, -1, -1, 8 );
			ac = new AddonComponent( 2330 );
			ac.Hue = 1150;
			ac.Name = "lamp shade";
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, -1, -1, 0 );
			//ac = new AddonComponent( 5015 );
			//ac.Hue = 1153;
			//AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 10809 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 10809 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 0, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 1, 17 );
			ac = new AddonComponent( 9375 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 0, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 1, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, 2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 0, -2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 1, -2, 17 );
			ac = new AddonComponent( 9376 );
			ac.Name = "Canopy";
			AddComponent( ac, 2, -2, 17 );
			//ac = AddComponent ( new SleeperRedCanopyPiece( 2686 ) );
			//ac.Hue = 37;
			//AddComponent( ac, 0, 1, 0 );
			//ac = AddComponent ( new SleeperRedCanopyPiece( 2681 ) );
			//ac.Hue = 37;
			//AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2767 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2768 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2764 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 2761 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 5645 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 5646 );
			AddComponent( ac, 2, -1, 0 );
			//ac = new AddonComponent( 5015 );
			//ac.Hue = 1153;
			//AddComponent( ac, 0, 1, 16 );

		}
		
		private SleeperRedCanopyAddon m_Sleeper;

		private SleeperBedBody m_SleeperBedBody;
		private bool m_Active = false;
		private Mobile m_Player;
		private Point3D m_Location;
		private bool m_Sleeping = false;
        private bool m_Debug = false;
		private Mobile m_Owner;

		//wtry is the "wake try" counter. After two attempts to wake someone else up, you get zapped
		private int wtry;

		[CommandProperty( AccessLevel.GameMaster )]
		public Point3D Bed
		{
			get{ return m_Location; }
			set{ m_Location = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Debug
		{
			get{ return m_Debug; }
			set{ m_Debug = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Active
		{
			get{ return m_Active; }
			set{ m_Active = value; InvalidateProperties(); }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Asleep
		{
			get{ return m_Sleeping; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Mobile
		{
			get{ return m_Player; }
			set
			{ 
				if( value == null )
					m_Active = false;
				else
					m_Active = true;

				m_Player = value; 

				InvalidateProperties();
			}
		}


		[CommandProperty( AccessLevel.GameMaster )]
		public SleeperRedCanopyAddon Sleeper
		{
			get{ return m_Sleeper; }
			set{}
		}

		private void Sleep()
		{
			if( m_Sleeping ) return;

		}

		public void DoubleClick( Mobile from ) 
		{ 
			Mobile m_Player = from as PlayerMobile;
			if(m_Player.CantWalk && !m_Sleeping)
			{
				m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You are already sleeping somewhere!" );
			}
			else
			{
				if( !m_Sleeping ) 
				{	
					BaseHouse m_house = BaseHouse.FindHouseAt( from );
					BaseHouse this_house = BaseHouse.FindHouseAt ( this );
					if (m_house!= null && (m_house != this_house))
					{
						from.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You cannot sleep in someone elses bed! Get a bed of your own." );
						return;
					}
					if ( m_house!= null && (m_house.IsOwner(from) || m_house.IsCoOwner(from) || m_house.IsFriend( from )))
					{
						wtry=0;
						m_Owner = m_Player;
						m_Player.Hidden = true;
						m_Player.CantWalk = true;
						m_Sleeping = true;
						m_SleeperBedBody = new SleeperBedBody( m_Player, false, false );
						Point3D m_Location = new Point3D(this.Location.X+1, this.Location.Y, this.Location.Z+5);
						m_SleeperBedBody.Direction=Direction.East;
						m_SleeperBedBody.MoveToWorld( m_Location, this.Map );
					}
					else
					{
						from.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You must be in the house and be the owner, co-owner or friend of the house this bed is in to sleep in it." );
						return;
					}

				}
				else 
				{
					if(m_Owner==m_Player)
					{
						m_Sleeping = false;
						m_Player.Hidden = false;
						m_Player.CantWalk = false;
						if( m_SleeperBedBody != null )
							m_SleeperBedBody.Delete();
						m_SleeperBedBody = null;
						switch( Utility.RandomMinMax( 1, 3 ) )
						{
						case 1:
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You wake up and feel rested and strong." );
							break;
						case 2:
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You spring out of bed, ready for another day!" );
							break;
						case 3:
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You fall out of bed and blearily reach for the coffee pot." );
							break;
						}
					}
					else
					{
						switch (wtry)
						{
						case 0:
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "Shhh, don't wake them up. They really need their beauty rest!" );
							wtry=wtry+1;
							break;
						case 1: 
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You really should NOT bother someone that is sleeping. Bad things might happen." );
							wtry=wtry+1;
							break;
						case 2:
							m_Player.LocalOverheadMessage( MessageType.Regular, 0x33, true, "You were warned!! Now leave them alone." );
							m_Player.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.Head );
							m_Player.PlaySound( 0x208 );
							m_Player.Hits=m_Player.Hits-40;
							break;
						}
					}
				}
			}
		}
		
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			string tmp = String.Format( "{0}: {1}", this.Name, ( m_Player != null ? m_Player.Name : "unassigned" ) );
			list.Add( tmp );

			if ( m_Active )
				list.Add( 1060742 ); // active
			else
				list.Add( 1060743 ); // inactive
		}



		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );

			writer.Write( (Item)m_SleeperBedBody );
			writer.Write( (Mobile)m_Player );
			writer.Write( m_Active );
			writer.Write( m_Location );
			writer.Write( m_Sleeping );
			writer.Write( (Mobile)m_Owner );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		
			m_SleeperBedBody = (SleeperBedBody)reader.ReadItem();
			m_Player = reader.ReadMobile();
			m_Active = reader.ReadBool();
			m_Location = reader.ReadPoint3D();
			m_Sleeping = reader.ReadBool();
			m_Owner = reader.ReadMobile();

			m_Debug = false;
		}



	}

	public class SleeperRedCanopyPiece : AddonComponent
	{

		private SleeperRedCanopyAddon m_Sleeper;

		public SleeperRedCanopyPiece( SleeperRedCanopyAddon sleeper, int itemid ) : base( itemid )
		{
			m_Sleeper = sleeper;
		}

		public override void OnDoubleClick( Mobile from ) 
		{ 
			m_Sleeper.DoubleClick(from);
		}

		public SleeperRedCanopyPiece( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			writer.Write( (Item)m_Sleeper );

		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			m_Sleeper = (SleeperRedCanopyAddon)reader.ReadItem();

		}

	}
   public class SleeperRedCanopyAddonDeed : BaseAddonDeed
    {
        public override BaseAddon Addon
        {
            get
            {
                return new SleeperRedCanopyAddon ();
            }
        }

        [Constructable]
        public SleeperRedCanopyAddonDeed ()
        {
            Name = "a red canopy sleeper facing east deed.";
        }

        public SleeperRedCanopyAddonDeed ( Serial serial )
            : base ( serial )
        {
        }

        public override void Serialize ( GenericWriter writer )
        {
            base.Serialize ( writer );
            writer.Write ( 0 ); // Version
        }

        public override void Deserialize ( GenericReader reader )
        {
            base.Deserialize ( reader );
            int version = reader.ReadInt ();
        }
    }
}
