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
	public class Celeste : BaseCreature 
	{ 
		[Constructable] 
		public Celeste() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Title = "the Queen of the Underworld";
			Name = "Celeste";
			Body = 745;
			Hue = 0;  

			SetStr( 900, 940 );
			SetDex( 191, 115 );
			SetInt( 670, 690 );

			SetHits( 1520, 1700 );

			SetDamage( 15, 18 );

			SetDamageType( ResistanceType.Physical, 100 );
	
			VirtualArmor = 55;

			SetSkill( SkillName.EvalInt, 100.0, 120.0 );
			SetSkill( SkillName.Tactics, 95.1, 110.0 );
			SetSkill( SkillName.MagicResist, 75.0, 97.5 );
			SetSkill( SkillName.Wrestling, 90.2, 110.0 );
			SetSkill( SkillName.Meditation, 120.0);
			SetSkill( SkillName.Focus, 120.0);
			SetSkill( SkillName.Magery, 120.0 );

			Fame = 15000;
			Karma = -15000;
            							
			VampireLeatherChest chest = new VampireLeatherChest();
			chest.Movable = false;
			chest.Hue = 906;
   			AddItem(chest);
   			
   			VampireLeatherGloves gloves = new VampireLeatherGloves();
   			gloves.Movable = false;
			gloves.Hue = 906;
  			AddItem(gloves);
  			
  			VampireLeatherGorget gorget = new VampireLeatherGorget();
  			gorget.Movable = false;
			gorget.Hue = 906;
 			AddItem(gorget);
 			
 			VampireLeatherLegs legs = new VampireLeatherLegs();
 			legs.Movable = false;
			legs.Hue = 906;
			AddItem(legs);

			VampireLeatherArms arms = new VampireLeatherArms();
			arms.Movable = false;
			arms.Hue = 906;
			AddItem(arms);

			VampireRobe VampireRobe = new VampireRobe();
			VampireRobe.Hue = 906;
			VampireRobe.Movable = false;
			AddItem(VampireRobe);
			
			Sandals sandals = new Sandals();
			sandals.Hue = 906;
			AddItem( sandals );

			HalfApron halfapron = new HalfApron();
			halfapron.Movable = false;
			halfapron.Hue = 906;
			halfapron.Layer = Layer.Waist;
			AddItem(halfapron);

			Item weapon = new ScytheOfFaith();
				weapon.Movable = false;
				weapon.Hue = 906;
			AddItem( weapon );

		}

		public override void GenerateLoot()
		{
			switch ( Utility.Random( 20 ))
			{
				case 0: PackItem( new ScytheOfFaith() ); break;
					
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

		public override bool AlwaysMurderer{ get{ return true; } }

		public Celeste( Serial serial ) : base( serial )
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
