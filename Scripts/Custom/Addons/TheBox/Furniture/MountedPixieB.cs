///////////////////////////////////////////////////////////
// The Sound Credit goes to my wonderful Brat, Tynsdale //
//////////////////////////////////////////////////////////


using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class MountedPixieB : AddonComponent
	{
		public override bool NeedsWall{ get{ return true; } }
		public override Point3D WallPosition{ get{ return this.East ? new Point3D( -1, 0, 0 ) : new Point3D( 0, -1, 0 ); } }

		public bool East{ get{ return this.ItemID == 0x2A74; } }

		[Constructable]
		public MountedPixieB() : this( true )
		{
		}

		[Constructable]
		public MountedPixieB( bool east ) : base( east ? 0x2A74 : 0x2A73 )
		{
		}

		public MountedPixieB( Serial serial ) : base( serial )
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
	
	public class MountedPixieBEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MountedPixieBEastDeed(); }}

		[Constructable]
		public MountedPixieBEastAddon()
		{
		    Name = "Mounted Pixie";
			
			AddComponent( new MountedPixieB( true ), 0, 0, 0 );
		}
        		
		public MountedPixieBEastAddon( Serial serial ) : base( serial )
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

	public class MountedPixieBEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MountedPixieBEastAddon(); }}

		[Constructable]
		public MountedPixieBEastDeed()
		{
		    Name = "Mounted Pixie East Deed";
		}

		public MountedPixieBEastDeed( Serial serial ) : base( serial )
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
	
	public class MountedPixieBSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new MountedPixieBSouthDeed(); }}
	
		[Constructable]
		public MountedPixieBSouthAddon()
		{
		    Name = "Mounted Pixie";
			
			AddComponent( new MountedPixieB( false ), 0, 0, 0 );
		}
        		
		public MountedPixieBSouthAddon( Serial serial ) : base( serial )
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

	public class MountedPixieBSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new MountedPixieBSouthAddon(); }}

		[Constructable]
		public MountedPixieBSouthDeed()
		{
		    Name = "Mounted Pixie South Deed";
		}

		public MountedPixieBSouthDeed( Serial serial ) : base( serial )
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