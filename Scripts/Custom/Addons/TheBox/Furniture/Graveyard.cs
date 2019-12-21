using System;
using Server;

namespace Server.Items
{
	public class GraveyardAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new GraveyardAddonDeed(); } }

		[Constructable]
		public GraveyardAddon()
		{
			//frame
			//AddComponent( new AddonComponent( 740 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 4, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 5, 0, 0 );
			AddComponent( new AddonComponent( 2083 ), 6, 0, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 4, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 5, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 6, 0 );
			//	AddComponent( new AddonComponent( 741 ), 0, 7, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 1, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 2, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 3, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 4, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 5, 0 );
			AddComponent( new AddonComponent( 2081 ), 6, 6, 0 );
			//Front
			AddComponent( new AddonComponent( 2082 ), 6, 7, 0 );
			AddComponent( new AddonComponent( 2081 ), 0, 7, 0 );
			AddComponent( new AddonComponent( 766 ), 1, 7, 0 );
			AddComponent( new AddonComponent( 766 ), 2, 7, 0 );
			AddComponent( new AddonComponent( 766 ), 4, 7, 0 );
			AddComponent( new AddonComponent( 766 ), 5, 7, 0 );
			//rave Stones South
			AddComponent( new AddonComponent( 4472 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 4476 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 3809 ), 4, 2, 0 );
			AddComponent( new AddonComponent( 3807 ), 4, 3, 0 );
			AddComponent( new AddonComponent( 4460 ), 4, 1, 0 );
			//Grave Stones east
			AddComponent( new AddonComponent( 3816 ), 2, 5, 0 );
			AddComponent( new AddonComponent( 3808 ), 3, 5, 0 );
			AddComponent( new AddonComponent( 3816 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 3808 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 4463 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 4467 ), 1, 5, 0 );
			//TopTree
			AddComponent( new AddonComponent( 8778 ), 1, 1, 0 );
			//body
			AddComponent( new AddonComponent( 7390 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 7411 ), 2, 2, 0 );
			//mummy
			AddComponent( new AddonComponent( 7478 ), 5, 4, 0 );
			AddComponent( new AddonComponent( 7480 ), 5, 5, 0 );
			AddComponent( new AddonComponent( 7479 ), 5, 6, 0 );
			//Grass
			AddComponent( new AddonComponent( 6017 ), 1, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 1, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 1, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 1, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 2, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 3, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 4, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 5, 7, 0 );
			//AddComponent( new AddonComponent( 6017 ), 7, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 7, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 6, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 5, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 4, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 3, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 2, 0 );
			AddComponent( new AddonComponent( 6017 ), 6, 1, 0 );
		}
		
		public GraveyardAddon( Serial serial ) : base( serial )
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
	
	
	public class GraveyardAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new GraveyardAddon(); } }
		//public override int LabelNumber{ get{ return 1044349; } } // water trough (east)
		
		[Constructable]
		public GraveyardAddonDeed()
		{
			Name = "Graveyard Addon";
		}
		
		public GraveyardAddonDeed( Serial serial ) : base( serial )
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
