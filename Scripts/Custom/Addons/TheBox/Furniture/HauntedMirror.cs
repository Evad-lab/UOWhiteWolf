///////////////////////////////////////////////////////////
// The Sound Credit goes to my wonderful Brat, Tynsdale  //
//////////////////////////////////////////////////////////



using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class HauntedMirror :  AddonComponent
	{
		public override bool NeedsWall{ get{ return true; } }
		public override Point3D WallPosition{ get{ return this.East ? new Point3D( -1, 0, 0 ) : new Point3D( 0, -1, 0 ); } }

		public bool East{ get{ return this.ItemID == 0x2A7D; } }

		[Constructable]
		public HauntedMirror() : this( true )
		{
		}

		[Constructable]
		public HauntedMirror( bool east ) : base( east ? 0x2A7D : 0x2A7B )
		{
		}

		public HauntedMirror( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile m )
		{
			Direction dir;
			if ( m.Location != this.Location )
				dir = m.GetDirectionTo( this );
			else if ( this.East )
				dir = Direction.West;
			else
				dir = Direction.North;

			m.Direction = dir;

			bool canTalk = true;

			if ( !m.InRange( this, 3 ) || !m.InLOS( this ))
				canTalk = false;
			else if ( this.East )
				canTalk = ( dir == Direction.Left || dir == Direction.West || dir == Direction.Up );
			else
				canTalk = ( dir == Direction.Up || dir == Direction.North || dir == Direction.Right );

			if ( canTalk )
				Talk( m );
			else
				m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
		}

		public void Talk( Mobile m )
		{
			m.PlaySound( Utility.RandomList( 0x550, 0x551, 0x542, 0x54F, 0x553, 0x54E, 0x566, 0x549 ));
		}
 		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}
        
		public override bool HandlesOnMovement{ get{ return true; } }
		
		public override void OnMovement( Mobile m, Point3D oldLocation ) 
		{ 
			if ( m.InRange( this, 5 ) ) 
			{ 
				//TimeSpan delay = TimeSpan.FromSeconds( 5.0 );
				switch ( ItemID ) 
				{ 
					//do swap or animation here 
					case 0x2A7D: this.ItemID=0x2A7E; break; //east
					case 0x2A7E: this.ItemID=0x2A7D; break; //east
					case 0x2A7B: this.ItemID=0x2A7C; break; //South
					case 0x2A7C: this.ItemID=0x2A7B; break; //South
					default: break; 
				}
            }
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
    }
			
	public class HauntedMirrorEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new HauntedMirrorEastDeed(); }}

		[Constructable]
		public HauntedMirrorEastAddon()
		{
		    Name = "Haunted Mirror";
			
			AddComponent( new HauntedMirror( true ), 0, 0, 0 );
		}
        		
		public HauntedMirrorEastAddon( Serial serial ) : base( serial )
		{
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
    }

	public class HauntedMirrorEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new HauntedMirrorEastAddon(); }}

		[Constructable]
		public HauntedMirrorEastDeed()
		{
		    Name = "Haunted Mirror East Deed";
		}

		public HauntedMirrorEastDeed( Serial serial ) : base( serial )
		{
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
	}
	
	public class HauntedMirrorSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new HauntedMirrorSouthDeed(); }}
	
		[Constructable]
		public HauntedMirrorSouthAddon()
		{
		    Name = "Haunted Mirror";
			
			AddComponent( new HauntedMirror( false ), 0, 0, 0 );
		}
        		
		public HauntedMirrorSouthAddon( Serial serial ) : base( serial )
		{
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
   	}

	public class HauntedMirrorSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new HauntedMirrorSouthAddon(); }}

		[Constructable]
		public HauntedMirrorSouthDeed()
		{
		    Name = "Haunted Mirror South Deed";
		}

		public HauntedMirrorSouthDeed( Serial serial ) : base( serial )
		{
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
	}
}