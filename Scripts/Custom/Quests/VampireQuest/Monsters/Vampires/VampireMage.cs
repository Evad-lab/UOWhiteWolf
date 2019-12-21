/////////////////
///LostSinner///
///////////////
using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles 
{ 
	[CorpseName( "an Vampire mage corpse" )] 
	public class VampireMage : BaseCreature 
	{ 
		[Constructable] 
		public VampireMage() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Title = "the Vampire Mage";
			Name = NameList.RandomName( "male" );
			Body = 400;
			Hue = 0;  

			SetStr( 400, 500 );
			SetDex( 91, 115 );
			SetInt( 300, 320 );

			SetHits( 620, 725 );

			SetDamage( 10, 15 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 0, 1 );
			SetResistance( ResistanceType.Fire, 0, 1 );
			SetResistance( ResistanceType.Poison, 0, 1 );
			SetResistance( ResistanceType.Energy, 0, 1 );

			SetSkill( SkillName.EvalInt, 85.0, 100.0 );
			SetSkill( SkillName.Tactics, 75.1, 100.0 );
			SetSkill( SkillName.MagicResist, 75.0, 97.5 );
			SetSkill( SkillName.Wrestling, 20.2, 60.0 );
			SetSkill( SkillName.Meditation, 120.0);
			SetSkill( SkillName.Focus, 120.0);
			SetSkill( SkillName.Magery, 100.0 );

			Fame = 2500;
			Karma = -2500;

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
			chest.Movable = false;
   			AddItem(chest);
   			
   			VampireLeatherGloves gloves = new VampireLeatherGloves();
   			gloves.Movable = false;
  			AddItem(gloves);
  			
  			VampireLeatherGorget gorget = new VampireLeatherGorget();
  			gorget.Movable = false;
 			AddItem(gorget);
 			
 			VampireLeatherLegs legs = new VampireLeatherLegs();
 			legs.Movable = false;
			AddItem(legs);

			VampireLeatherArms arms = new VampireLeatherArms();
			arms.Movable = false;
			AddItem(arms);

			VampireRobe robe = new VampireRobe();
			robe.Movable = false;
			AddItem(robe);
			
			Sandals sandals = new Sandals();
			sandals.Hue = 1;
			AddItem( sandals );

		}

		public override void GenerateLoot()
		{
			
			switch ( Utility.Random( 15 ))
			{
				case 0: PackItem( new VampireLeatherChest() ); break;
				case 1: PackItem( new VampireLeatherGloves() ); break;
				case 2: PackItem( new VampireLeatherGorget() ); break;
				case 3: PackItem( new VampireLeatherLegs() ); break;
				case 4: PackItem( new VampireLeatherArms() ); break;
				case 5: PackItem( new VampireRobe() ); break;
			}
					
			PackGold( 2575, 2700);
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
        public override bool BardImmune { get { return true; } }

		public VampireMage( Serial serial ) : base( serial )
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
