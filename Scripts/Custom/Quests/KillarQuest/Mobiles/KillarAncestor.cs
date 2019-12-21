using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "an KillarAncestor corpse" )]
	public class KillarAncestor : BaseCreature
	{
		[Constructable]
		public KillarAncestor() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Killar Ancestor";
			
		        Body = 400;
			Hue = 1360;
			
			BaseSoundID = 1154;

			SetStr( 1800 );
			SetDex( 1510, 1750 );
			SetInt( 1710, 2200 );

			SetHits( 1500 );

			SetDamage( 34, 36 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 45 );
			SetResistance( ResistanceType.Cold, 45 );
			SetResistance( ResistanceType.Poison, 45 );
			SetResistance( ResistanceType.Energy, 45 );

			SetSkill( SkillName.EvalInt, 130.0 );
			SetSkill( SkillName.Magery, 130.0 );
			SetSkill( SkillName.Meditation, 130.0 );
			SetSkill( SkillName.MagicResist, 90.0 );
			SetSkill( SkillName.Tactics, 130.0 );
			SetSkill( SkillName.Wrestling, 130.0 );

       		       Nightmare mare = new Nightmare();
        	       mare.Hue = 1;
        	       mare.Rider = this;


			Fame = 0;
			Karma = -20000;

			VirtualArmor = 64;


        		AddItem( new Robe( 1360 ) );
			AddItem( new FancyShirt( 1360 ) );
			AddItem( new Doublet( 1360 ) ); 
         		AddItem( new Cloak( 1360 ) ); 
         		AddItem( new Sandals( 1360 ) );
                        
		 
			PackGem();
			PackGold( 4700, 6950 );
			//PackItem( new Tokens( 2000, 3000 ) );
			PackItem( new HatOfKillar() );


		switch ( Utility.Random( 100 ) ) //Rarity 10 
                        { 
                          case 0: PackItem( new TheTaskmaster( ) ); 
                          break; 
                          case 1: PackItem( new ZyronicClaw( ) ); 
                          break; 
                          case 2: PackItem( new BladeOfTheRighteous( ) ); 
                          break; 
                          case 3: PackItem( new TitansHammer( ) ); 
                          break; 
                          case 4: PackItem( new InquisitorsResolution( ) ); 
                          break; 
                        } 

                         switch ( Utility.Random( 150 ) ) //Rarity 11 
                        { 
                          case 0: PackItem( new AxeOfTheHeavens( ) ); 
                          break; 
                          case 1: PackItem( new BladeOfInsanity( ) ); 
                          break; 
                          case 2: PackItem( new BoneCrusher( ) ); 
                          break; 
                          case 3: PackItem( new BreathOfTheDead( ) ); 
                          break; 
                          case 4: PackItem( new Frostbringer( ) ); 
                          break; 
                          case 5: PackItem( new LegacyOfTheDreadLord( ) ); 
                          break; 
                          case 6: PackItem( new SerpentsFang( ) ); 
                          break; 
                          case 7: PackItem( new StaffOfTheMagi( ) ); 
                          break; 
                          case 8: PackItem( new TheBeserkersMaul( ) ); 
                          break; 
                          case 9: PackItem( new TheDragonSlayer( ) ); 
                          break; 
                          case 10: PackItem( new ArmorOfFortune( ) ); 
                          break; 
                          case 11: PackItem( new OrnateCrownOfTheHarrower( ) ); 
                          break; 
                          case 12: PackItem( new MidnightBracers( ) ); 
                          break; 
                          case 13: PackItem( new LeggingsOfBane( ) ); 
                          break; 
                          case 14: PackItem( new JackalsCollar( ) ); 
                          break; 
                          case 15: PackItem( new HuntersHeaddress( ) ); 
                          break; 
                          case 16: PackItem( new HolyKnightsBreastplate( ) ); 
                          break; 
                          case 17: PackItem( new HelmOfInsight( ) ); 
                          break; 
                          case 18: PackItem( new HatOfTheMagi( ) ); 
                          break; 
                          case 19: PackItem( new GauntletsOfNobility( ) ); 
                          break; 
                          case 20: PackItem( new DivineCountenance( ) ); 
                          break; 
                          case 21: PackItem( new VoiceOfTheFallenKing( ) ); 
                          break; 
                          case 22: PackItem( new TunicOfFire( ) ); 
                          break; 
                          case 23: PackItem( new SpiritOfTheTotem( ) ); 
                          break; 
                          case 24: PackItem( new BraceletOfHealth( ) ); 
                          break; 
                          case 25: PackItem( new OrnamentOfTheMagician( ) ); 
                          break; 
                          case 26: PackItem( new RingOfTheElements( ) ); 
                          break; 
                          case 27: PackItem( new RingOfTheVile( ) ); 
                          break;  
                        } 
                 } 



		public override bool Unprovokable{ get{ return true; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 1; } 
               }

		public KillarAncestor( Serial serial ) : base( serial )
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