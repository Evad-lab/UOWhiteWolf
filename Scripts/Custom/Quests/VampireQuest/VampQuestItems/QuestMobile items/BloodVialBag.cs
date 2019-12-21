
//////////////////////////
//Created by LostSinner//
////////////////////////
using System; 
using Server; 
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{ 
   	public class BloodVialBag : Bag 
   	{ 
      		[Constructable] 
      		public BloodVialBag() : this( 1 ) 
      		{ 
			Movable = true; 
			Hue = 39; 
			Name = "a bag of Vials";
      		} 
		[Constructable]
		public BloodVialBag( int amount )
		{
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
			DropItem( new EmptyBloodVial1() );
		
		}


      		public BloodVialBag( Serial serial ) : base( serial ) 
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
