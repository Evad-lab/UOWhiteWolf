
//////////////////////////
//Created by LostSinner//
////////////////////////
using System; 
using Server; 
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{ 
   	public class VengenceGemBag : Bag 
   	{ 
      		[Constructable] 
      		public VengenceGemBag() : this( 1 ) 
      		{ 
			Movable = true; 
			Hue = 39; 
			Name = "a bag of empty Vengence Gems";
      		} 
		[Constructable]
		public VengenceGemBag( int amount )
		{

			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );
			DropItem( new EmptyVengenceGem1() );	
		}


      		public VengenceGemBag( Serial serial ) : base( serial ) 
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
