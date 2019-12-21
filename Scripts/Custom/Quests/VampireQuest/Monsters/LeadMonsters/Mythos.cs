/////////////////
///LostSinner///
///////////////
using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles 
{ 
	[CorpseName( "an Vampiriac corpse" )] 
	public class Mythos : BaseCreature 
	{ 
		[Constructable] 
		public Mythos() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Title = "the Frozen Horror";
			Name = "Mythos";
			Body = 400;
			Hue = 0;  

			SetStr( 900, 940 );
			SetDex( 191, 115 );
			SetInt( 670, 690 );

			SetHits( 1120, 1300 );

			SetDamage( 15, 18 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetSkill( SkillName.EvalInt, 100.0, 120.0 );
			SetSkill( SkillName.Tactics, 95.1, 110.0 );
			SetSkill( SkillName.MagicResist, 75.0, 97.5 );
			SetSkill( SkillName.Wrestling, 90.2, 110.0 );
			SetSkill( SkillName.Meditation, 120.0);
			SetSkill( SkillName.Focus, 120.0);
			SetSkill( SkillName.Magery, 120.0 );
			
			Fame = 15000;
			Karma = -25000;

			VirtualArmor = 50;

			Item hair = new Item( Utility.RandomList( 0x203B, 0x2049, 0x2048, 0x204A ) );
			
				hair.Hue = 1150;
				hair.Layer = Layer.Hair;
				hair.Movable = false;
				AddItem( hair );
			
			Item beard = new Item( Utility.RandomList( 0x203E, 0x203F, 0x2040, 0x2041, 0x204B, 0x204C, 0x204D ) );

				beard.Hue = hair.Hue;
				beard.Layer = Layer.FacialHair;
				beard.Movable = false;
				AddItem( beard );
				
				
			VampireLeatherChest chest = new VampireLeatherChest();
			chest.Hue = 295;
			chest.Movable = false;
   			AddItem(chest);
  			
  			VampireLeatherGorget gorget = new VampireLeatherGorget();
			gorget.Hue = 295;
  			gorget.Movable = false;
 			AddItem(gorget);
 			
 			VampireLeatherLegs legs = new VampireLeatherLegs();
			legs.Hue = 295;
 			legs.Movable = false;
			AddItem(legs);

			VampireLeatherArms arms = new VampireLeatherArms();
			arms.Hue = 295;
			arms.Movable = false;
			AddItem(arms);

			VampireRobe VampireRobe = new VampireRobe();
			VampireRobe.Hue = 295;
			VampireRobe.Movable = false;
			AddItem(VampireRobe);
			
			Sandals sandals = new Sandals();
			sandals.Hue = 295;
			AddItem( sandals );
			
			HalfApron halfapron = new HalfApron();
			halfapron.Movable = false;
			halfapron.Hue = 295;
			halfapron.Layer = Layer.Waist;
			AddItem(halfapron);

			Item weapon = new FistsOfPainandFury();
				weapon.Movable = false;
				weapon.Hue = 295;
			AddItem( weapon );

			
		}

		public override void GenerateLoot()
		{
			switch ( Utility.Random( 20 ))
			{
				case 0: PackItem( new FistsOfPainandFury() ); break;
				
			}
			
			switch ( Utility.Random( 10 ))
			{
				case 0: PackItem( new VampireLeatherChest() ); break;
				case 1: PackItem( new VampireLeatherGloves() ); break;
				case 2: PackItem( new VampireLeatherGorget() ); break;
				case 3: PackItem( new VampireLeatherLegs() ); break;
				case 4: PackItem( new VampireLeatherArms() ); break;
				case 5: PackItem( new VampireRobe() ); break;
			}
					

			PackGold( 6575, 7700);
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 );
		}

		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public Mythos( Serial serial ) : base( serial )
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
}
