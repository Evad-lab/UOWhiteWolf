///////////////////////////////////////////////////////////
// The Sound Credit goes to my wonderful Brat, Tynsdale //
//////////////////////////////////////////////////////////


using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class MountedPixieE : AddonComponent
	{
		public override bool NeedsWall{ get{ return true; } }
		public override Point3D WallPosition{ get{ return this.East ? new Point3D( -1, 0, 0 ) : new Point3D( 0, -1, 0 ); } }

		public bool East{ get{ return this.ItemID == 0x2A7A; } }

		[Constructable]
		public MountedPixieE() : this( true )
		{
		}

		[Constructable]
		public MountedPixieE( bool east ) : base( east ? 0x2A7A : 0x2A79 )
		{
		}

		public MountedPixieE( Serial serial ) : base( serial )
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

			if ( !m.InRange( this, 2 ) || !m.InLOS( this ))
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
			m.PlaySound( Utility.RandomList( 0x554, 0x555, 0x556, 0x557, 0x558, 0x559, 0x55A, 0x55B, 0x55C, 0x55D, 0x55E, 0x55F, 0x560, 0x561, 0x562, 0x563, 0x564 ));
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
	
	public class MountedPixieEEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MountedPixieEEastDeed(); }}

		[Constructable]
		public MountedPixieEEastAddon()
		{
		    Name = "Mounted Pixie";
			
			AddComponent( new MountedPixieE( true ), 0, 0, 0 );
		}
        		
		public MountedPixieEEastAddon( Serial serial ) : base( serial )
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

	public class MountedPixieEEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MountedPixieEEastAddon(); }}

		[Constructable]
		public MountedPixieEEastDeed()
		{
		    Name = "Mounted Pixie East Deed";
		}

		public MountedPixieEEastDeed( Serial serial ) : base( serial )
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
	
	public class MountedPixieESouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MountedPixieESouthDeed(); }}
	
		[Constructable]
		public MountedPixieESouthAddon()
		{
		    Name = "Mounted Pixie";
			
			AddComponent( new MountedPixieE( false ), 0, 0, 0 );
		}
        		
		public MountedPixieESouthAddon( Serial serial ) : base( serial )
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

	public class MountedPixieESouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MountedPixieESouthAddon(); }}

		[Constructable]
		public MountedPixieESouthDeed()
		{
		    Name = "Mounted Pixie South Deed";
		}

		public MountedPixieESouthDeed( Serial serial ) : base( serial )
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