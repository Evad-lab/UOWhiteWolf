
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server.Network;
using Server.Items;


namespace Server.Items
{
 
	[FlipableAttribute( 0x26C2, 0x26CC )]
 	public class VampiriacBow : noammoBaseRanged
 	{
  		public override int EffectID{ get{ return 0xF42; } }
  		public override Type AmmoType{ get{ return typeof( Arrow ); } }
  		public override Item Ammo{ get{ return new Arrow(); } }
 
  		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
  		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MovingShot; } }
 
  		public override int AosStrengthReq{ get{ return 30; } }
  		public override int AosMinDamage{ get{ return 16; } }
  		public override int AosMaxDamage{ get{ return 18; } }
  		public override int AosSpeed{ get{ return 25; } }
 
  		public override int OldStrengthReq{ get{ return 20; } }
  		public override int OldMinDamage{ get{ return 9; } }
  		public override int OldMaxDamage{ get{ return 20; } }
  		public override int OldSpeed{ get{ return 20; } }
 
 		public override int DefMaxRange{ get{ return 10; } }
 
  		public override int InitMinHits{ get{ return 255; } }
  		public override int InitMaxHits{ get{ return 255; } }
        public override float MlSpeed{ get{return 4.00f;} }
 
  		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.ShootBow; } }
 
  		[Constructable]
  		public VampiriacBow() : base( 0x26C2 )
  		{
   			Weight = 6.0;
   			Name = "A Vampiriac Bow";
   			Hue = 37;
   			Layer = Layer.TwoHanded;
			Attributes.SpellChanneling = 1;
   			Attributes.WeaponSpeed = 30;
   			Attributes.WeaponDamage = 35;
   			Attributes.AttackChance = 30;
   			WeaponAttributes.HitLeechHits = 50;
   			Attributes.CastSpeed = 2;
   			Attributes.CastRecovery = 4;
 		 }
 
 		 public VampiriacBow( Serial serial ) : base( serial )
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
 
   			if ( Weight == 7.0 )
   			 Weight = 6.0;
  		 }
	}
}
